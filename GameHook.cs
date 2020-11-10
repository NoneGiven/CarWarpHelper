﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MemTools;

namespace CarWarpHelper {
  [StructLayout(LayoutKind.Sequential)]
  struct Vect3F {
    public Single X;
    public Single Y;
    public Single Z;
  }

  static class GameHook {
    private static MemManager manager = null;
    private static Pointer posPtrP1 = null;
    private static Pointer posPtrP2 = null;

    public static bool IsHookedP1 => manager != null && manager.IsHooked && posPtrP1 != null;
    public static bool IsHookedP2 => manager != null && manager.IsHooked && posPtrP2 != null;

    public static Vect3F PositionP1 {
      get {
        if (!IsHookedP1 && !TryHook()) {
          return default;
        }
        return manager.Read<Vect3F>(posPtrP1);
      }
      set {
        if (!IsHookedP1 && !TryHook()) {
          return;
        }
        manager.Write<Vect3F>(posPtrP1, value);
      }
    }

    public static Vect3F PositionP2 {
      get {
        if ((!IsHookedP1 && !TryHook()) || !IsHookedP2) {
          return default;
        }
        return manager.Read<Vect3F>(posPtrP2);
      }
      set {
        if ((!IsHookedP1 && !TryHook()) || !IsHookedP2) {
          return;
        }
        manager.Write<Vect3F>(posPtrP2, value);
      }
    }

    public static bool TryHook() {
      foreach (Process p in Process.GetProcessesByName("Borderlands3")) {
        manager = new MemManager(p);

        try {
          IntPtr ptr = manager.SigScan(
            p.MainModule.BaseAddress,
            p.MainModule.ModuleMemorySize,
            31,
            "88 1D ????????",     // mov [Borderlands3.exe + 6802764], bl
            "E8 ????????",        // call Borderlands3.exe + 3C8D4C0
            "48 8D 0D ????????",  // lea rcx,[Borderlands3.exe + 6802768]
            "E8 ????????",        // call Borderlands3.exe + 3C8D690
            "48 8B 5C 24 20",     // mov rbx,[rsp + 20]
            "48 8D 05 ????????",  // lea rax,[Borderlands3.exe + 6802670] < ---
            "48 83 C4 28",        // add rsp, 28
            "C3"                  // ret
          );

          if (ptr == IntPtr.Zero) {
            continue;
          }

          /*
            These instructions are directly around the function sigscanned above:
              call <function>
              mov rsi,rax
              ...
              cmp rbp, [rsi+000000D0]

            This compare is what accesses the `OakLocalPlayer` object we want.
            Going to assume the 0xDO is constant to make dealing with all this easier.
          */

          Int64 baseAddr = ptr.ToInt64() + 4 + manager.Read<Int32>(ptr);
          baseAddr += 0xD0;

          /*
            Don't know exact field names but this is roughly what the pointer follows:
            OakLocalPlayer -> OakPlayerController.Pawn -> CapsuleComponent/CollisionCylinder -> Location
          */
          posPtrP1 = new Pointer(new IntPtr(baseAddr), 0x0, 0x30, 0x488, 0x168, 0x220);
          //posPtrP2 = new Pointer(new IntPtr(baseAddr), 0x0, 0x30, 0x488, 0x168, 0x220); // sktodo
          break;

        } catch (Win32Exception) {
          continue;
        }
      }
      return IsHookedP1;
    }
  }
}
