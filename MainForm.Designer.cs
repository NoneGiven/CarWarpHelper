namespace CarWarpHelper {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.notHookedLabel = new System.Windows.Forms.Label();
            this.xInputP1 = new System.Windows.Forms.NumericUpDown();
            this.yInputP1 = new System.Windows.Forms.NumericUpDown();
            this.zInputP1 = new System.Windows.Forms.NumericUpDown();
            this.zLockP1 = new System.Windows.Forms.CheckBox();
            this.xLockP1 = new System.Windows.Forms.CheckBox();
            this.yLockP1 = new System.Windows.Forms.CheckBox();
            this.positionTable = new System.Windows.Forms.TableLayoutPanel();
            this.positionLabelP1 = new System.Windows.Forms.Label();
            this.lockLabelP1 = new System.Windows.Forms.Label();
            this.prevMapButton = new System.Windows.Forms.Button();
            this.nextMapButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mapLabel = new System.Windows.Forms.Label();
            this.nextStationButton = new System.Windows.Forms.Button();
            this.stationLabel = new System.Windows.Forms.Label();
            this.prevStationButton = new System.Windows.Forms.Button();
            this.autoTeleportBox = new System.Windows.Forms.CheckBox();
            this.locationHeader = new System.Windows.Forms.Label();
            this.teleportButton = new System.Windows.Forms.Button();
            this.savePosButttonP1 = new System.Windows.Forms.Button();
            this.loadPosButtonP1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.positionLabelP2 = new System.Windows.Forms.Label();
            this.zLockP2 = new System.Windows.Forms.CheckBox();
            this.yLockP2 = new System.Windows.Forms.CheckBox();
            this.lockLabelP2 = new System.Windows.Forms.Label();
            this.xLockP2 = new System.Windows.Forms.CheckBox();
            this.xInputP2 = new System.Windows.Forms.NumericUpDown();
            this.yInputP2 = new System.Windows.Forms.NumericUpDown();
            this.zInputP2 = new System.Windows.Forms.NumericUpDown();
            this.loadPosButtonP2 = new System.Windows.Forms.Button();
            this.savePosButttonP2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xInputP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInputP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zInputP1)).BeginInit();
            this.positionTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xInputP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInputP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zInputP2)).BeginInit();
            this.SuspendLayout();
            // 
            // notHookedLabel
            // 
            this.notHookedLabel.BackColor = System.Drawing.Color.Crimson;
            this.notHookedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notHookedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notHookedLabel.ForeColor = System.Drawing.Color.White;
            this.notHookedLabel.Location = new System.Drawing.Point(0, 0);
            this.notHookedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notHookedLabel.Name = "notHookedLabel";
            this.notHookedLabel.Size = new System.Drawing.Size(605, 313);
            this.notHookedLabel.TabIndex = 28;
            this.notHookedLabel.Text = "Not Hooked";
            this.notHookedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notHookedLabel.Visible = false;
            // 
            // xInputP1
            // 
            this.xInputP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xInputP1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xInputP1.Location = new System.Drawing.Point(4, 24);
            this.xInputP1.Margin = new System.Windows.Forms.Padding(4);
            this.xInputP1.Name = "xInputP1";
            this.xInputP1.Size = new System.Drawing.Size(200, 22);
            this.xInputP1.TabIndex = 0;
            this.xInputP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xInputP1.ValueChanged += new System.EventHandler(this.Position_ValueChanged_P1);
            this.xInputP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Position_KeyDown);
            // 
            // yInputP1
            // 
            this.yInputP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yInputP1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yInputP1.Location = new System.Drawing.Point(4, 54);
            this.yInputP1.Margin = new System.Windows.Forms.Padding(4);
            this.yInputP1.Name = "yInputP1";
            this.yInputP1.Size = new System.Drawing.Size(200, 22);
            this.yInputP1.TabIndex = 8;
            this.yInputP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yInputP1.ValueChanged += new System.EventHandler(this.Position_ValueChanged_P1);
            this.yInputP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Position_KeyDown);
            // 
            // zInputP1
            // 
            this.zInputP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zInputP1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zInputP1.Location = new System.Drawing.Point(4, 84);
            this.zInputP1.Margin = new System.Windows.Forms.Padding(4);
            this.zInputP1.Name = "zInputP1";
            this.zInputP1.Size = new System.Drawing.Size(200, 22);
            this.zInputP1.TabIndex = 9;
            this.zInputP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zInputP1.ValueChanged += new System.EventHandler(this.Position_ValueChanged_P1);
            this.zInputP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Position_KeyDown);
            // 
            // zLockP1
            // 
            this.zLockP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zLockP1.AutoSize = true;
            this.zLockP1.Location = new System.Drawing.Point(223, 86);
            this.zLockP1.Margin = new System.Windows.Forms.Padding(4);
            this.zLockP1.Name = "zLockP1";
            this.zLockP1.Size = new System.Drawing.Size(18, 17);
            this.zLockP1.TabIndex = 14;
            this.zLockP1.UseVisualStyleBackColor = true;
            // 
            // xLockP1
            // 
            this.xLockP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xLockP1.AutoSize = true;
            this.xLockP1.Location = new System.Drawing.Point(223, 26);
            this.xLockP1.Margin = new System.Windows.Forms.Padding(4);
            this.xLockP1.Name = "xLockP1";
            this.xLockP1.Size = new System.Drawing.Size(18, 17);
            this.xLockP1.TabIndex = 15;
            this.xLockP1.UseVisualStyleBackColor = true;
            // 
            // yLockP1
            // 
            this.yLockP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yLockP1.AutoSize = true;
            this.yLockP1.Location = new System.Drawing.Point(223, 56);
            this.yLockP1.Margin = new System.Windows.Forms.Padding(4);
            this.yLockP1.Name = "yLockP1";
            this.yLockP1.Size = new System.Drawing.Size(18, 17);
            this.yLockP1.TabIndex = 16;
            this.yLockP1.UseVisualStyleBackColor = true;
            // 
            // positionTable
            // 
            this.positionTable.AutoSize = true;
            this.positionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.positionTable.ColumnCount = 2;
            this.positionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.positionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.positionTable.Controls.Add(this.positionLabelP1, 0, 0);
            this.positionTable.Controls.Add(this.zLockP1, 1, 3);
            this.positionTable.Controls.Add(this.yLockP1, 1, 2);
            this.positionTable.Controls.Add(this.lockLabelP1, 1, 0);
            this.positionTable.Controls.Add(this.xLockP1, 1, 1);
            this.positionTable.Controls.Add(this.zInputP1, 0, 3);
            this.positionTable.Controls.Add(this.xInputP1, 0, 1);
            this.positionTable.Controls.Add(this.yInputP1, 0, 2);
            this.positionTable.Location = new System.Drawing.Point(16, 15);
            this.positionTable.Margin = new System.Windows.Forms.Padding(4);
            this.positionTable.Name = "positionTable";
            this.positionTable.RowCount = 5;
            this.positionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.positionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.positionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.positionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.positionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.positionTable.Size = new System.Drawing.Size(257, 130);
            this.positionTable.TabIndex = 20;
            // 
            // positionLabelP1
            // 
            this.positionLabelP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionLabelP1.AutoSize = true;
            this.positionLabelP1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.positionLabelP1.Location = new System.Drawing.Point(71, 0);
            this.positionLabelP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabelP1.Name = "positionLabelP1";
            this.positionLabelP1.Size = new System.Drawing.Size(66, 20);
            this.positionLabelP1.TabIndex = 0;
            this.positionLabelP1.Text = "Position";
            // 
            // lockLabelP1
            // 
            this.lockLabelP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lockLabelP1.AutoSize = true;
            this.lockLabelP1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockLabelP1.Location = new System.Drawing.Point(212, 0);
            this.lockLabelP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lockLabelP1.Name = "lockLabelP1";
            this.lockLabelP1.Size = new System.Drawing.Size(41, 20);
            this.lockLabelP1.TabIndex = 1;
            this.lockLabelP1.Text = "Lock";
            // 
            // prevMapButton
            // 
            this.prevMapButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevMapButton.Location = new System.Drawing.Point(4, 4);
            this.prevMapButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevMapButton.Name = "prevMapButton";
            this.prevMapButton.Size = new System.Drawing.Size(31, 28);
            this.prevMapButton.TabIndex = 21;
            this.prevMapButton.Text = "<";
            this.prevMapButton.UseVisualStyleBackColor = true;
            this.prevMapButton.Click += new System.EventHandler(this.PrevMapButton_Click);
            // 
            // nextMapButton
            // 
            this.nextMapButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextMapButton.Location = new System.Drawing.Point(225, 4);
            this.nextMapButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextMapButton.Name = "nextMapButton";
            this.nextMapButton.Size = new System.Drawing.Size(31, 28);
            this.nextMapButton.TabIndex = 22;
            this.nextMapButton.Text = ">";
            this.nextMapButton.UseVisualStyleBackColor = true;
            this.nextMapButton.Click += new System.EventHandler(this.NextMapButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.mapLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.prevMapButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nextMapButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nextStationButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.stationLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.prevStationButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 191);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 72);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // mapLabel
            // 
            this.mapLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(112, 9);
            this.mapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(35, 17);
            this.mapLabel.TabIndex = 23;
            this.mapLabel.Text = "Map";
            this.mapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextStationButton
            // 
            this.nextStationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextStationButton.Location = new System.Drawing.Point(225, 40);
            this.nextStationButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextStationButton.Name = "nextStationButton";
            this.nextStationButton.Size = new System.Drawing.Size(31, 28);
            this.nextStationButton.TabIndex = 24;
            this.nextStationButton.Text = ">";
            this.nextStationButton.UseVisualStyleBackColor = true;
            this.nextStationButton.Click += new System.EventHandler(this.NextStationButton_Click);
            // 
            // stationLabel
            // 
            this.stationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(98, 45);
            this.stationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(63, 17);
            this.stationLabel.TabIndex = 25;
            this.stationLabel.Text = "Terminal";
            this.stationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevStationButton
            // 
            this.prevStationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevStationButton.Location = new System.Drawing.Point(4, 40);
            this.prevStationButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevStationButton.Name = "prevStationButton";
            this.prevStationButton.Size = new System.Drawing.Size(31, 28);
            this.prevStationButton.TabIndex = 26;
            this.prevStationButton.Text = "<";
            this.prevStationButton.UseVisualStyleBackColor = true;
            this.prevStationButton.Click += new System.EventHandler(this.PrevStationButton_Click);
            // 
            // autoTeleportBox
            // 
            this.autoTeleportBox.AutoSize = true;
            this.autoTeleportBox.Location = new System.Drawing.Point(212, 274);
            this.autoTeleportBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoTeleportBox.Name = "autoTeleportBox";
            this.autoTeleportBox.Size = new System.Drawing.Size(59, 21);
            this.autoTeleportBox.TabIndex = 25;
            this.autoTeleportBox.Text = "Auto";
            this.autoTeleportBox.UseVisualStyleBackColor = true;
            // 
            // locationHeader
            // 
            this.locationHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.locationHeader.Location = new System.Drawing.Point(16, 169);
            this.locationHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationHeader.Name = "locationHeader";
            this.locationHeader.Size = new System.Drawing.Size(260, 18);
            this.locationHeader.TabIndex = 26;
            this.locationHeader.Text = "Catch-A-Rides";
            this.locationHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teleportButton
            // 
            this.teleportButton.Location = new System.Drawing.Point(16, 270);
            this.teleportButton.Margin = new System.Windows.Forms.Padding(4);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(188, 28);
            this.teleportButton.TabIndex = 27;
            this.teleportButton.Text = "Teleport";
            this.teleportButton.UseVisualStyleBackColor = true;
            this.teleportButton.Click += new System.EventHandler(this.TeleportButton_Click);
            // 
            // savePosButttonP1
            // 
            this.savePosButttonP1.Location = new System.Drawing.Point(16, 137);
            this.savePosButttonP1.Margin = new System.Windows.Forms.Padding(4);
            this.savePosButttonP1.Name = "savePosButttonP1";
            this.savePosButttonP1.Size = new System.Drawing.Size(125, 28);
            this.savePosButttonP1.TabIndex = 29;
            this.savePosButttonP1.Text = "Save";
            this.savePosButttonP1.UseVisualStyleBackColor = true;
            this.savePosButttonP1.Click += new System.EventHandler(this.SavePosButtton_Click_P1);
            // 
            // loadPosButtonP1
            // 
            this.loadPosButtonP1.Enabled = false;
            this.loadPosButtonP1.Location = new System.Drawing.Point(151, 137);
            this.loadPosButtonP1.Margin = new System.Windows.Forms.Padding(4);
            this.loadPosButtonP1.Name = "loadPosButtonP1";
            this.loadPosButtonP1.Size = new System.Drawing.Size(125, 28);
            this.loadPosButtonP1.TabIndex = 30;
            this.loadPosButtonP1.Text = "Load";
            this.loadPosButtonP1.UseVisualStyleBackColor = true;
            this.loadPosButtonP1.Click += new System.EventHandler(this.LoadPosButton_Click_P1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.positionLabelP2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zLockP2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.yLockP2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lockLabelP2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.xLockP2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.xInputP2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.yInputP2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.zInputP2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(330, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 110);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // positionLabelP2
            // 
            this.positionLabelP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionLabelP2.AutoSize = true;
            this.positionLabelP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.positionLabelP2.Location = new System.Drawing.Point(71, 0);
            this.positionLabelP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabelP2.Name = "positionLabelP2";
            this.positionLabelP2.Size = new System.Drawing.Size(66, 20);
            this.positionLabelP2.TabIndex = 0;
            this.positionLabelP2.Text = "Position";
            // 
            // zLockP2
            // 
            this.zLockP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zLockP2.AutoSize = true;
            this.zLockP2.Location = new System.Drawing.Point(223, 86);
            this.zLockP2.Margin = new System.Windows.Forms.Padding(4);
            this.zLockP2.Name = "zLockP2";
            this.zLockP2.Size = new System.Drawing.Size(18, 17);
            this.zLockP2.TabIndex = 14;
            this.zLockP2.UseVisualStyleBackColor = true;
            // 
            // yLockP2
            // 
            this.yLockP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yLockP2.AutoSize = true;
            this.yLockP2.Location = new System.Drawing.Point(223, 56);
            this.yLockP2.Margin = new System.Windows.Forms.Padding(4);
            this.yLockP2.Name = "yLockP2";
            this.yLockP2.Size = new System.Drawing.Size(18, 17);
            this.yLockP2.TabIndex = 16;
            this.yLockP2.UseVisualStyleBackColor = true;
            // 
            // lockLabelP2
            // 
            this.lockLabelP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lockLabelP2.AutoSize = true;
            this.lockLabelP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockLabelP2.Location = new System.Drawing.Point(212, 0);
            this.lockLabelP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lockLabelP2.Name = "lockLabelP2";
            this.lockLabelP2.Size = new System.Drawing.Size(41, 20);
            this.lockLabelP2.TabIndex = 1;
            this.lockLabelP2.Text = "Lock";
            // 
            // xLockP2
            // 
            this.xLockP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xLockP2.AutoSize = true;
            this.xLockP2.Location = new System.Drawing.Point(223, 26);
            this.xLockP2.Margin = new System.Windows.Forms.Padding(4);
            this.xLockP2.Name = "xLockP2";
            this.xLockP2.Size = new System.Drawing.Size(18, 17);
            this.xLockP2.TabIndex = 15;
            this.xLockP2.UseVisualStyleBackColor = true;
            // 
            // xInputP2
            // 
            this.xInputP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xInputP2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xInputP2.Location = new System.Drawing.Point(4, 84);
            this.xInputP2.Margin = new System.Windows.Forms.Padding(4);
            this.xInputP2.Name = "xInputP2";
            this.xInputP2.Size = new System.Drawing.Size(200, 22);
            this.xInputP2.TabIndex = 9;
            this.xInputP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xInputP2.ValueChanged += new System.EventHandler(this.Position_ValueChanged_P2);
            this.xInputP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Position_KeyDown);
            // 
            // yInputP2
            // 
            this.yInputP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yInputP2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yInputP2.Location = new System.Drawing.Point(4, 24);
            this.yInputP2.Margin = new System.Windows.Forms.Padding(4);
            this.yInputP2.Name = "yInputP2";
            this.yInputP2.Size = new System.Drawing.Size(200, 22);
            this.yInputP2.TabIndex = 0;
            this.yInputP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yInputP2.ValueChanged += new System.EventHandler(this.Position_ValueChanged_P2);
            this.yInputP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Position_KeyDown);
            // 
            // zInputP2
            // 
            this.zInputP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zInputP2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zInputP2.Location = new System.Drawing.Point(4, 54);
            this.zInputP2.Margin = new System.Windows.Forms.Padding(4);
            this.zInputP2.Name = "zInputP2";
            this.zInputP2.Size = new System.Drawing.Size(200, 22);
            this.zInputP2.TabIndex = 8;
            this.zInputP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zInputP2.ValueChanged += new System.EventHandler(this.Position_ValueChanged_P2);
            this.zInputP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Position_KeyDown);
            // 
            // loadPosButtonP2
            // 
            this.loadPosButtonP2.Enabled = false;
            this.loadPosButtonP2.Location = new System.Drawing.Point(465, 137);
            this.loadPosButtonP2.Margin = new System.Windows.Forms.Padding(4);
            this.loadPosButtonP2.Name = "loadPosButtonP2";
            this.loadPosButtonP2.Size = new System.Drawing.Size(125, 28);
            this.loadPosButtonP2.TabIndex = 32;
            this.loadPosButtonP2.Text = "Load";
            this.loadPosButtonP2.UseVisualStyleBackColor = true;
            this.loadPosButtonP2.Click += new System.EventHandler(this.LoadPosButton_Click_P2);
            // 
            // savePosButttonP2
            // 
            this.savePosButttonP2.Location = new System.Drawing.Point(330, 137);
            this.savePosButttonP2.Margin = new System.Windows.Forms.Padding(4);
            this.savePosButttonP2.Name = "savePosButttonP2";
            this.savePosButttonP2.Size = new System.Drawing.Size(125, 28);
            this.savePosButttonP2.TabIndex = 31;
            this.savePosButttonP2.Text = "Save";
            this.savePosButttonP2.UseVisualStyleBackColor = true;
            this.savePosButttonP2.Click += new System.EventHandler(this.SavePosButtton_Click_P2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 313);
            this.Controls.Add(this.loadPosButtonP2);
            this.Controls.Add(this.savePosButttonP2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.loadPosButtonP1);
            this.Controls.Add(this.savePosButttonP1);
            this.Controls.Add(this.teleportButton);
            this.Controls.Add(this.locationHeader);
            this.Controls.Add(this.autoTeleportBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.positionTable);
            this.Controls.Add(this.notHookedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Car Warp Helper";
            ((System.ComponentModel.ISupportInitialize)(this.xInputP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInputP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zInputP1)).EndInit();
            this.positionTable.ResumeLayout(false);
            this.positionTable.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xInputP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInputP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zInputP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion


        private System.Windows.Forms.Label notHookedLabel;
        private System.Windows.Forms.TableLayoutPanel positionTable;
        private System.Windows.Forms.Label positionLabelP1;
        private System.Windows.Forms.Label lockLabelP1;
        private System.Windows.Forms.Button prevMapButton;
        private System.Windows.Forms.Button nextMapButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.Button nextStationButton;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Button prevStationButton;
        private System.Windows.Forms.Label locationHeader;
        private System.Windows.Forms.Button teleportButton;
    private System.Windows.Forms.Button savePosButttonP1;
    private System.Windows.Forms.Button loadPosButtonP1;
        internal System.Windows.Forms.CheckBox zLockP1;
        internal System.Windows.Forms.CheckBox xLockP1;
        internal System.Windows.Forms.CheckBox yLockP1;
        internal System.Windows.Forms.CheckBox autoTeleportBox;
        private System.Windows.Forms.NumericUpDown xInputP1;
        private System.Windows.Forms.NumericUpDown yInputP1;
        private System.Windows.Forms.NumericUpDown zInputP1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label positionLabelP2;
        internal System.Windows.Forms.CheckBox zLockP2;
        internal System.Windows.Forms.CheckBox yLockP2;
        private System.Windows.Forms.Label lockLabelP2;
        internal System.Windows.Forms.CheckBox xLockP2;
        private System.Windows.Forms.NumericUpDown xInputP2;
        private System.Windows.Forms.NumericUpDown yInputP2;
        private System.Windows.Forms.NumericUpDown zInputP2;
        private System.Windows.Forms.Button loadPosButtonP2;
        private System.Windows.Forms.Button savePosButttonP2;
    }
}

