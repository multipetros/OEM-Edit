/*
 * oemedit main form class designer
 * Copyright (C) 2013, Petros Kyladitis
 * 
 * This program is free software distributed under the GNU GPL 3,
 * for license details see at 'license.txt' file, distributed with
 * this project, or see at <http://www.gnu.org/licenses/>.
 */
 
namespace oemedit
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelManufacturer = new System.Windows.Forms.Label();
			this.textBoxManufacturer = new System.Windows.Forms.TextBox();
			this.textBoxModel = new System.Windows.Forms.TextBox();
			this.labelModel = new System.Windows.Forms.Label();
			this.textBoxSupportHours = new System.Windows.Forms.TextBox();
			this.labelSupportHours = new System.Windows.Forms.Label();
			this.textBoxSupportTel = new System.Windows.Forms.TextBox();
			this.labelSupportTel = new System.Windows.Forms.Label();
			this.textBoxLogoPath = new System.Windows.Forms.TextBox();
			this.labelLogo = new System.Windows.Forms.Label();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.openFileDialogSelectLogo = new System.Windows.Forms.OpenFileDialog();
			this.textBoxSupportUrl = new System.Windows.Forms.TextBox();
			this.labelSupportUrl = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonClearOemInfo = new System.Windows.Forms.Button();
			this.buttonClearLogo = new System.Windows.Forms.Button();
			this.groupBoxLine = new System.Windows.Forms.GroupBox();
			this.menuStripMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// labelManufacturer
			// 
			this.labelManufacturer.Location = new System.Drawing.Point(5, 33);
			this.labelManufacturer.Name = "labelManufacturer";
			this.labelManufacturer.Size = new System.Drawing.Size(85, 23);
			this.labelManufacturer.TabIndex = 0;
			this.labelManufacturer.Text = "Manufacturer";
			// 
			// textBoxManufacturer
			// 
			this.textBoxManufacturer.Location = new System.Drawing.Point(96, 36);
			this.textBoxManufacturer.Name = "textBoxManufacturer";
			this.textBoxManufacturer.Size = new System.Drawing.Size(115, 20);
			this.textBoxManufacturer.TabIndex = 1;
			// 
			// textBoxModel
			// 
			this.textBoxModel.Location = new System.Drawing.Point(96, 62);
			this.textBoxModel.Name = "textBoxModel";
			this.textBoxModel.Size = new System.Drawing.Size(115, 20);
			this.textBoxModel.TabIndex = 3;
			// 
			// labelModel
			// 
			this.labelModel.Location = new System.Drawing.Point(5, 59);
			this.labelModel.Name = "labelModel";
			this.labelModel.Size = new System.Drawing.Size(85, 23);
			this.labelModel.TabIndex = 2;
			this.labelModel.Text = "Model";
			// 
			// textBoxSupportHours
			// 
			this.textBoxSupportHours.Location = new System.Drawing.Point(96, 88);
			this.textBoxSupportHours.Name = "textBoxSupportHours";
			this.textBoxSupportHours.Size = new System.Drawing.Size(115, 20);
			this.textBoxSupportHours.TabIndex = 5;
			// 
			// labelSupportHours
			// 
			this.labelSupportHours.Location = new System.Drawing.Point(5, 85);
			this.labelSupportHours.Name = "labelSupportHours";
			this.labelSupportHours.Size = new System.Drawing.Size(85, 23);
			this.labelSupportHours.TabIndex = 4;
			this.labelSupportHours.Text = "Support Hours";
			// 
			// textBoxSupportTel
			// 
			this.textBoxSupportTel.Location = new System.Drawing.Point(96, 114);
			this.textBoxSupportTel.Name = "textBoxSupportTel";
			this.textBoxSupportTel.Size = new System.Drawing.Size(115, 20);
			this.textBoxSupportTel.TabIndex = 7;
			// 
			// labelSupportTel
			// 
			this.labelSupportTel.Location = new System.Drawing.Point(5, 111);
			this.labelSupportTel.Name = "labelSupportTel";
			this.labelSupportTel.Size = new System.Drawing.Size(85, 23);
			this.labelSupportTel.TabIndex = 6;
			this.labelSupportTel.Text = "Support Tel.";
			// 
			// textBoxLogoPath
			// 
			this.textBoxLogoPath.Location = new System.Drawing.Point(54, 166);
			this.textBoxLogoPath.Name = "textBoxLogoPath";
			this.textBoxLogoPath.ReadOnly = true;
			this.textBoxLogoPath.Size = new System.Drawing.Size(157, 20);
			this.textBoxLogoPath.TabIndex = 9;
			// 
			// labelLogo
			// 
			this.labelLogo.Location = new System.Drawing.Point(5, 166);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(43, 23);
			this.labelLogo.TabIndex = 8;
			this.labelLogo.Text = "Logo";
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(354, 24);
			this.menuStripMain.TabIndex = 10;
			this.menuStripMain.Text = "menuStripMain";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// buttonSelect
			// 
			this.buttonSelect.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelect.Image")));
			this.buttonSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSelect.Location = new System.Drawing.Point(221, 162);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(96, 24);
			this.buttonSelect.TabIndex = 11;
			this.buttonSelect.Text = "Select";
			this.buttonSelect.UseVisualStyleBackColor = true;
			this.buttonSelect.Click += new System.EventHandler(this.ButtonSelectClick);
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Location = new System.Drawing.Point(221, 36);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(120, 120);
			this.pictureBoxLogo.TabIndex = 12;
			this.pictureBoxLogo.TabStop = false;
			// 
			// openFileDialogSelectLogo
			// 
			this.openFileDialogSelectLogo.FileName = "oemlogo.bmp";
			this.openFileDialogSelectLogo.Filter = "Bitmap|*.bmp";
			this.openFileDialogSelectLogo.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogSelectLogoFileOk);
			// 
			// textBoxSupportUrl
			// 
			this.textBoxSupportUrl.Location = new System.Drawing.Point(96, 140);
			this.textBoxSupportUrl.Name = "textBoxSupportUrl";
			this.textBoxSupportUrl.Size = new System.Drawing.Size(115, 20);
			this.textBoxSupportUrl.TabIndex = 14;
			// 
			// labelSupportUrl
			// 
			this.labelSupportUrl.Location = new System.Drawing.Point(5, 137);
			this.labelSupportUrl.Name = "labelSupportUrl";
			this.labelSupportUrl.Size = new System.Drawing.Size(85, 23);
			this.labelSupportUrl.TabIndex = 13;
			this.labelSupportUrl.Text = "Support URL";
			// 
			// buttonSave
			// 
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSave.Location = new System.Drawing.Point(5, 210);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(110, 24);
			this.buttonSave.TabIndex = 15;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCancel.Location = new System.Drawing.Point(121, 210);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(110, 24);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// buttonClearOemInfo
			// 
			this.buttonClearOemInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearOemInfo.Image")));
			this.buttonClearOemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClearOemInfo.Location = new System.Drawing.Point(237, 210);
			this.buttonClearOemInfo.Name = "buttonClearOemInfo";
			this.buttonClearOemInfo.Size = new System.Drawing.Size(110, 24);
			this.buttonClearOemInfo.TabIndex = 17;
			this.buttonClearOemInfo.Text = "Clear OEM Info";
			this.buttonClearOemInfo.UseVisualStyleBackColor = true;
			this.buttonClearOemInfo.Click += new System.EventHandler(this.ButtonClearOemInfoClick);
			// 
			// buttonClearLogo
			// 
			this.buttonClearLogo.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearLogo.Image")));
			this.buttonClearLogo.Location = new System.Drawing.Point(317, 162);
			this.buttonClearLogo.Name = "buttonClearLogo";
			this.buttonClearLogo.Size = new System.Drawing.Size(24, 24);
			this.buttonClearLogo.TabIndex = 18;
			this.buttonClearLogo.UseVisualStyleBackColor = true;
			this.buttonClearLogo.Click += new System.EventHandler(this.ButtonClearLogoClick);
			// 
			// groupBoxLine
			// 
			this.groupBoxLine.Location = new System.Drawing.Point(15, 198);
			this.groupBoxLine.Name = "groupBoxLine";
			this.groupBoxLine.Size = new System.Drawing.Size(320, 2);
			this.groupBoxLine.TabIndex = 19;
			this.groupBoxLine.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 246);
			this.Controls.Add(this.groupBoxLine);
			this.Controls.Add(this.buttonClearLogo);
			this.Controls.Add(this.buttonClearOemInfo);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxSupportUrl);
			this.Controls.Add(this.labelSupportUrl);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.textBoxLogoPath);
			this.Controls.Add(this.labelLogo);
			this.Controls.Add(this.textBoxSupportTel);
			this.Controls.Add(this.labelSupportTel);
			this.Controls.Add(this.textBoxSupportHours);
			this.Controls.Add(this.labelSupportHours);
			this.Controls.Add(this.textBoxModel);
			this.Controls.Add(this.labelModel);
			this.Controls.Add(this.textBoxManufacturer);
			this.Controls.Add(this.labelManufacturer);
			this.Controls.Add(this.menuStripMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "OEM Information Editor";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBoxLine;
		private System.Windows.Forms.Button buttonClearLogo;
		private System.Windows.Forms.Label labelManufacturer;
		private System.Windows.Forms.TextBox textBoxManufacturer;
		private System.Windows.Forms.TextBox textBoxModel;
		private System.Windows.Forms.Label labelModel;
		private System.Windows.Forms.TextBox textBoxSupportHours;
		private System.Windows.Forms.Label labelSupportHours;
		private System.Windows.Forms.TextBox textBoxSupportTel;
		private System.Windows.Forms.Label labelSupportTel;
		private System.Windows.Forms.TextBox textBoxLogoPath;
		private System.Windows.Forms.Label labelLogo;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.OpenFileDialog openFileDialogSelectLogo;
		private System.Windows.Forms.TextBox textBoxSupportUrl;
		private System.Windows.Forms.Label labelSupportUrl;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonClearOemInfo;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripMain;
	}
}
