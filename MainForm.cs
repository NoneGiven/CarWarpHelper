using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarWarpHelper {
  public partial class MainForm : Form {
    private static readonly int[] UPDATE_OPTIONS = new int[] {
      1, 5, 10, 17, 50, 100, 500, 1000
    };

    private int updateMS = UPDATE_OPTIONS[2];
    private readonly Timer UpdateTimer;

    private readonly List<NumericUpDown> allPosInputsP1;
    private readonly List<NumericUpDown> allPosInputsP2;
    private readonly StationManager stationMgr;
    private readonly BindingForm binds;

    private Vect3F? savedPosP1 = null;
    private Vect3F? savedPosP2 = null;

    public MainForm() {
      InitializeComponent();

      EnsureHooked();

      // This is at the very back so that I can keep using the visual editor,
      //  but needs to be at the very front at runtime for actual use
      Controls.SetChildIndex(notHookedLabel, 0);

      allPosInputsP1 = new List<NumericUpDown>() { xInputP1, yInputP1, zInputP1 };
      allPosInputsP2 = new List<NumericUpDown>() { xInputP2, yInputP2, zInputP2 };
      foreach (NumericUpDown input in allPosInputsP1) {
        input.Minimum = decimal.MinValue;
        input.Maximum = decimal.MaxValue;
      }
      foreach (NumericUpDown input in allPosInputsP2) {
        input.Minimum = decimal.MinValue;
        input.Maximum = decimal.MaxValue;
      }

      stationMgr = new StationManager();
      mapLabel.Text = stationMgr.World;
      stationLabel.Text = stationMgr.Station;

      binds = new BindingForm(this);

      ContextMenuStrip = new ContextMenuStrip();

      ToolStripMenuItem dropDown = new ToolStripMenuItem("Polling Rate (ms)");
      foreach (int option in UPDATE_OPTIONS) {
        ToolStripMenuItem sub = new ToolStripMenuItem(option.ToString()) {
          CheckOnClick = true,
          Checked = option == updateMS
        };
        sub.Click += new EventHandler(ChangeUpdateRate);
        dropDown.DropDownItems.Add(sub);
      }
      ContextMenuStrip.Items.Add(dropDown);

      ToolStripMenuItem keybinds = new ToolStripMenuItem("Configure Keybinds");
      keybinds.Click += KeybindMenuItem_Click;
      ContextMenuStrip.Items.Add(keybinds);

      UpdateTimer = new Timer() {
        Interval = updateMS
      };
      UpdateTimer.Tick += new EventHandler(Update);
      UpdateTimer.Start();
    }

    private bool EnsureHooked() {
      if (!GameHook.IsHookedP1) {
        if (GameHook.TryHook()) {
          notHookedLabel.Visible = false;
        } else {
          notHookedLabel.Visible = true;
          return false;
        }
      }
      return true;
    }

    private void ChangeUpdateRate(object myObject, EventArgs myEventArgs) {
      ToolStripMenuItem dropDown = (ToolStripMenuItem) ContextMenuStrip.Items[0];
      for (int i = 0; i < dropDown.DropDownItems.Count; i++) {
        ToolStripMenuItem item = (ToolStripMenuItem) dropDown.DropDownItems[i];
        if (item == myObject) {
          updateMS = UPDATE_OPTIONS[i];
        } else {
          item.Checked = false;
        }
      }

      UpdateTimer.Stop();
      UpdateTimer.Interval = updateMS;
      UpdateTimer.Start();
    }

    private void Update(object myObject, EventArgs myEventArgs) {
      if (!EnsureHooked()) {
        return;
      }

      allPosInputsP1.ForEach(input => input.ValueChanged -= Position_ValueChanged_P1);
      
      try {
        Vect3F posP1 = GameHook.PositionP1;

        if (xLockP1.Checked) {
          posP1.X = Convert.ToSingle(xInputP1.Value);
        } else {
          xInputP1.Value = Convert.ToDecimal(GameHook.PositionP1.X);
        }

        if (yLockP1.Checked) {
          posP1.Y = Convert.ToSingle(yInputP1.Value);
        } else {
          yInputP1.Value = Convert.ToDecimal(GameHook.PositionP1.Y);
        }

        if (zLockP1.Checked) {
          posP1.Z = Convert.ToSingle(zInputP1.Value);
        } else {
          zInputP1.Value = Convert.ToDecimal(GameHook.PositionP1.Z);
        }

        if (xLockP1.Checked || yLockP1.Checked || zLockP1.Checked) {
          GameHook.PositionP1 = posP1;
        }

        allPosInputsP1.ForEach(input => input.Enabled = true);

      // Should be caused by invalid pointers - most likely you're on the main menu
      } catch (Win32Exception) {
        allPosInputsP1.ForEach(input => input.Enabled = false);
      }

      allPosInputsP1.ForEach(input => input.ValueChanged += Position_ValueChanged_P1);

      allPosInputsP2.ForEach(input => input.ValueChanged -= Position_ValueChanged_P2);
      
      try {
        Vect3F posP2 = GameHook.PositionP2;

        if (xLockP2.Checked) {
          posP2.X = Convert.ToSingle(xInputP2.Value);
        } else {
          xInputP2.Value = Convert.ToDecimal(GameHook.PositionP2.X);
        }

        if (yLockP2.Checked) {
          posP2.Y = Convert.ToSingle(yInputP2.Value);
        } else {
          yInputP2.Value = Convert.ToDecimal(GameHook.PositionP2.Y);
        }

        if (zLockP2.Checked) {
          posP2.Z = Convert.ToSingle(zInputP2.Value);
        } else {
          zInputP2.Value = Convert.ToDecimal(GameHook.PositionP2.Z);
        }

        if (xLockP2.Checked || yLockP2.Checked || zLockP2.Checked) {
          GameHook.PositionP2 = posP2;
        }

        allPosInputsP2.ForEach(input => input.Enabled = true);

      // Should be caused by invalid pointers - most likely you're on the main menu
      } catch (Win32Exception) {
        allPosInputsP2.ForEach(input => input.Enabled = false);
      }

      allPosInputsP2.ForEach(input => input.ValueChanged += Position_ValueChanged_P2);
    }

    private void KeybindMenuItem_Click(object sender, EventArgs e) {
      if (binds.Visible) {
        binds.BringToFront();
      } else {
        binds.Show();
      }
    }

    private void Position_ValueChanged_P1(object sender, EventArgs e) {
      if (!EnsureHooked()) {
        return;
      }

      try {
        Vect3F pos = GameHook.PositionP1;
        pos.X = Convert.ToSingle(xInputP1.Value);
        pos.Y = Convert.ToSingle(yInputP1.Value);
        pos.Z = Convert.ToSingle(zInputP1.Value);
        GameHook.PositionP1 = pos;
      } catch (Win32Exception) { }
    }

    private void Position_ValueChanged_P2(object sender, EventArgs e) {
    if (!EnsureHooked()) {
        return;
      }

      try {
        Vect3F pos = GameHook.PositionP2;
        pos.X = Convert.ToSingle(xInputP2.Value);
        pos.Y = Convert.ToSingle(yInputP2.Value);
        pos.Z = Convert.ToSingle(zInputP2.Value);
        GameHook.PositionP2 = pos;
      } catch (Win32Exception) { }
    }

    // This just prevents the error noise when you press enter
    private void Position_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        e.SuppressKeyPress = true;
      }
    }

    internal void SavePosButtton_Click_P1(object sender, EventArgs e) {
      if (!EnsureHooked()) {
        return;
      }


      try {
        savedPosP1 = GameHook.PositionP1;
        loadPosButtonP1.Enabled = true;
      } catch (Win32Exception) { }
    }

    internal void SavePosButtton_Click_P2(object sender, EventArgs e) {
      if (!EnsureHooked()) {
        return;
      }


      try {
        savedPosP2 = GameHook.PositionP2;
        loadPosButtonP2.Enabled = true;
      } catch (Win32Exception) { }
    }

    internal void LoadPosButton_Click_P1(object sender, EventArgs e) {
      if (!EnsureHooked()) {
        return;
      }

      if (savedPosP1.HasValue) {
        try {
          GameHook.PositionP1 = savedPosP1.Value;

          allPosInputsP1.ForEach(input => input.ValueChanged -= Position_ValueChanged_P1);
          xInputP1.Value = Convert.ToDecimal(savedPosP1.Value.X);
          yInputP1.Value = Convert.ToDecimal(savedPosP1.Value.Y);
          zInputP1.Value = Convert.ToDecimal(savedPosP1.Value.Z);
          allPosInputsP1.ForEach(input => input.ValueChanged += Position_ValueChanged_P1);
        } catch (Win32Exception) { }
      }
    }

    internal void LoadPosButton_Click_P2(object sender, EventArgs e) {
      if (!EnsureHooked()) {
        return;
      }

      if (savedPosP2.HasValue) {
        try {
          GameHook.PositionP2 = savedPosP2.Value;

          allPosInputsP2.ForEach(input => input.ValueChanged -= Position_ValueChanged_P2);
          xInputP2.Value = Convert.ToDecimal(savedPosP2.Value.X);
          yInputP2.Value = Convert.ToDecimal(savedPosP2.Value.Y);
          zInputP2.Value = Convert.ToDecimal(savedPosP2.Value.Z);
          allPosInputsP2.ForEach(input => input.ValueChanged += Position_ValueChanged_P2);
        } catch (Win32Exception) { }
      }
    }

    internal void NextMapButton_Click(object sender, EventArgs e) {
      stationMgr.NextMap();

      mapLabel.Text = stationMgr.World;
      stationLabel.Text = stationMgr.Station;

      if (autoTeleportBox.Checked) {
        TeleportButton_Click(this, null);
      }
    }

    internal void PrevMapButton_Click(object sender, EventArgs e) {
      stationMgr.PrevMap();
      
      mapLabel.Text = stationMgr.World;
      stationLabel.Text = stationMgr.Station;

      if (autoTeleportBox.Checked) {
        TeleportButton_Click(this, null);
      }
    }

    internal void NextStationButton_Click(object sender, EventArgs e) {
      stationMgr.NextStation();

      mapLabel.Text = stationMgr.World;
      stationLabel.Text = stationMgr.Station;

      if (autoTeleportBox.Checked) {
        TeleportButton_Click(this, null);
      }
    }

    internal void PrevStationButton_Click(object sender, EventArgs e) {
      stationMgr.PrevStation();

      mapLabel.Text = stationMgr.World;
      stationLabel.Text = stationMgr.Station;

      if (autoTeleportBox.Checked) {
        TeleportButton_Click(this, null);
      }
    }

    internal void TeleportButton_Click(object sender, EventArgs e) {
      if (!EnsureHooked()) {
        return;
      }

      try {
        GameHook.PositionP1 = stationMgr.Coords;

        allPosInputsP1.ForEach(input => input.ValueChanged -= Position_ValueChanged_P1);
        xInputP1.Value = Convert.ToDecimal(stationMgr.Coords.X);
        yInputP1.Value = Convert.ToDecimal(stationMgr.Coords.Y);
        zInputP1.Value = Convert.ToDecimal(stationMgr.Coords.Z);
        allPosInputsP1.ForEach(input => input.ValueChanged += Position_ValueChanged_P1);
      } catch (Win32Exception) { }
    }
  }
}
