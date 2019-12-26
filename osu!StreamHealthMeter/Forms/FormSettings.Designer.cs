namespace OsuStreamHealthMeter.Forms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudWindowWidth = new System.Windows.Forms.NumericUpDown();
            this.lbWindowWidth = new System.Windows.Forms.Label();
            this.lbWindowHeight = new System.Windows.Forms.Label();
            this.nudWindowHeight = new System.Windows.Forms.NumericUpDown();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lbFrameRate = new System.Windows.Forms.Label();
            this.nudFrameRate = new System.Windows.Forms.NumericUpDown();
            this.gpProfiles = new System.Windows.Forms.GroupBox();
            this.lbProfileName = new System.Windows.Forms.Label();
            this.tbProfileName = new System.Windows.Forms.TextBox();
            this.btProfileSave = new System.Windows.Forms.Button();
            this.btProfileAdd = new System.Windows.Forms.Button();
            this.dgwProfileLevels = new System.Windows.Forms.DataGridView();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.lbProfileActive = new System.Windows.Forms.Label();
            this.gpWindow = new System.Windows.Forms.GroupBox();
            this.btAddLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameRate)).BeginInit();
            this.gpProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfileLevels)).BeginInit();
            this.gpWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudWindowWidth
            // 
            this.nudWindowWidth.Location = new System.Drawing.Point(189, 19);
            this.nudWindowWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWindowWidth.Name = "nudWindowWidth";
            this.nudWindowWidth.Size = new System.Drawing.Size(165, 20);
            this.nudWindowWidth.TabIndex = 1;
            this.nudWindowWidth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // lbWindowWidth
            // 
            this.lbWindowWidth.AutoSize = true;
            this.lbWindowWidth.Location = new System.Drawing.Point(6, 21);
            this.lbWindowWidth.Name = "lbWindowWidth";
            this.lbWindowWidth.Size = new System.Drawing.Size(80, 13);
            this.lbWindowWidth.TabIndex = 2;
            this.lbWindowWidth.Text = "Window Width:";
            // 
            // lbWindowHeight
            // 
            this.lbWindowHeight.AutoSize = true;
            this.lbWindowHeight.Location = new System.Drawing.Point(6, 47);
            this.lbWindowHeight.Name = "lbWindowHeight";
            this.lbWindowHeight.Size = new System.Drawing.Size(83, 13);
            this.lbWindowHeight.TabIndex = 3;
            this.lbWindowHeight.Text = "Window Height:";
            // 
            // nudWindowHeight
            // 
            this.nudWindowHeight.Location = new System.Drawing.Point(189, 45);
            this.nudWindowHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWindowHeight.Name = "nudWindowHeight";
            this.nudWindowHeight.Size = new System.Drawing.Size(165, 20);
            this.nudWindowHeight.TabIndex = 4;
            this.nudWindowHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(297, 526);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(216, 526);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.SaveSettings);
            // 
            // lbFrameRate
            // 
            this.lbFrameRate.AutoSize = true;
            this.lbFrameRate.Location = new System.Drawing.Point(6, 73);
            this.lbFrameRate.Name = "lbFrameRate";
            this.lbFrameRate.Size = new System.Drawing.Size(65, 13);
            this.lbFrameRate.TabIndex = 10;
            this.lbFrameRate.Text = "Frame Rate:";
            // 
            // nudFrameRate
            // 
            this.nudFrameRate.Location = new System.Drawing.Point(189, 71);
            this.nudFrameRate.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFrameRate.Name = "nudFrameRate";
            this.nudFrameRate.Size = new System.Drawing.Size(165, 20);
            this.nudFrameRate.TabIndex = 11;
            this.nudFrameRate.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // gpProfiles
            // 
            this.gpProfiles.Controls.Add(this.btAddLevel);
            this.gpProfiles.Controls.Add(this.lbProfileName);
            this.gpProfiles.Controls.Add(this.tbProfileName);
            this.gpProfiles.Controls.Add(this.btProfileSave);
            this.gpProfiles.Controls.Add(this.btProfileAdd);
            this.gpProfiles.Controls.Add(this.dgwProfileLevels);
            this.gpProfiles.Controls.Add(this.cbProfiles);
            this.gpProfiles.Controls.Add(this.lbProfileActive);
            this.gpProfiles.Location = new System.Drawing.Point(12, 145);
            this.gpProfiles.Name = "gpProfiles";
            this.gpProfiles.Size = new System.Drawing.Size(360, 375);
            this.gpProfiles.TabIndex = 12;
            this.gpProfiles.TabStop = false;
            this.gpProfiles.Text = "Profiles";
            // 
            // lbProfileName
            // 
            this.lbProfileName.AutoSize = true;
            this.lbProfileName.Location = new System.Drawing.Point(111, 49);
            this.lbProfileName.Name = "lbProfileName";
            this.lbProfileName.Size = new System.Drawing.Size(72, 13);
            this.lbProfileName.TabIndex = 19;
            this.lbProfileName.Text = "Active Profile:";
            // 
            // tbProfileName
            // 
            this.tbProfileName.Location = new System.Drawing.Point(189, 46);
            this.tbProfileName.Name = "tbProfileName";
            this.tbProfileName.Size = new System.Drawing.Size(165, 20);
            this.tbProfileName.TabIndex = 18;
            // 
            // btProfileSave
            // 
            this.btProfileSave.Location = new System.Drawing.Point(279, 346);
            this.btProfileSave.Name = "btProfileSave";
            this.btProfileSave.Size = new System.Drawing.Size(75, 23);
            this.btProfileSave.TabIndex = 17;
            this.btProfileSave.Text = "Save Profile";
            this.btProfileSave.UseVisualStyleBackColor = true;
            this.btProfileSave.Click += new System.EventHandler(this.SaveProfile);
            // 
            // btProfileAdd
            // 
            this.btProfileAdd.Location = new System.Drawing.Point(84, 17);
            this.btProfileAdd.Name = "btProfileAdd";
            this.btProfileAdd.Size = new System.Drawing.Size(99, 23);
            this.btProfileAdd.TabIndex = 16;
            this.btProfileAdd.Text = "Add New Profile";
            this.btProfileAdd.UseVisualStyleBackColor = true;
            this.btProfileAdd.Click += new System.EventHandler(this.AddProfile);
            // 
            // dgwProfileLevels
            // 
            this.dgwProfileLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfileLevels.Location = new System.Drawing.Point(9, 72);
            this.dgwProfileLevels.Name = "dgwProfileLevels";
            this.dgwProfileLevels.Size = new System.Drawing.Size(345, 268);
            this.dgwProfileLevels.TabIndex = 15;
            // 
            // cbProfiles
            // 
            this.cbProfiles.DisplayMember = "Name";
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(189, 19);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(165, 21);
            this.cbProfiles.TabIndex = 14;
            this.cbProfiles.SelectedIndexChanged += new System.EventHandler(this.cbProfiles_SelectedIndexChanged);
            // 
            // lbProfileActive
            // 
            this.lbProfileActive.AutoSize = true;
            this.lbProfileActive.Location = new System.Drawing.Point(6, 22);
            this.lbProfileActive.Name = "lbProfileActive";
            this.lbProfileActive.Size = new System.Drawing.Size(72, 13);
            this.lbProfileActive.TabIndex = 13;
            this.lbProfileActive.Text = "Active Profile:";
            // 
            // gpWindow
            // 
            this.gpWindow.Controls.Add(this.lbWindowWidth);
            this.gpWindow.Controls.Add(this.lbWindowHeight);
            this.gpWindow.Controls.Add(this.nudFrameRate);
            this.gpWindow.Controls.Add(this.lbFrameRate);
            this.gpWindow.Controls.Add(this.nudWindowWidth);
            this.gpWindow.Controls.Add(this.nudWindowHeight);
            this.gpWindow.Location = new System.Drawing.Point(12, 12);
            this.gpWindow.Name = "gpWindow";
            this.gpWindow.Size = new System.Drawing.Size(360, 127);
            this.gpWindow.TabIndex = 13;
            this.gpWindow.TabStop = false;
            this.gpWindow.Text = "Window";
            // 
            // btAddLevel
            // 
            this.btAddLevel.Location = new System.Drawing.Point(198, 346);
            this.btAddLevel.Name = "btAddLevel";
            this.btAddLevel.Size = new System.Drawing.Size(75, 23);
            this.btAddLevel.TabIndex = 20;
            this.btAddLevel.Text = "Add Level";
            this.btAddLevel.UseVisualStyleBackColor = true;
            this.btAddLevel.Click += new System.EventHandler(this.btAddLevel_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.gpWindow);
            this.Controls.Add(this.gpProfiles);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameRate)).EndInit();
            this.gpProfiles.ResumeLayout(false);
            this.gpProfiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfileLevels)).EndInit();
            this.gpWindow.ResumeLayout(false);
            this.gpWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudWindowWidth;
        private System.Windows.Forms.Label lbWindowWidth;
        private System.Windows.Forms.Label lbWindowHeight;
        private System.Windows.Forms.NumericUpDown nudWindowHeight;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lbFrameRate;
        private System.Windows.Forms.NumericUpDown nudFrameRate;
        private System.Windows.Forms.GroupBox gpProfiles;
        private System.Windows.Forms.Label lbProfileActive;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.DataGridView dgwProfileLevels;
        private System.Windows.Forms.GroupBox gpWindow;
        private System.Windows.Forms.Button btProfileAdd;
        private System.Windows.Forms.Button btProfileSave;
        private System.Windows.Forms.Label lbProfileName;
        private System.Windows.Forms.TextBox tbProfileName;
        private System.Windows.Forms.Button btAddLevel;
    }
}