﻿namespace Music_VK
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxImageTrack = new System.Windows.Forms.PictureBox();
            this.menuMainForm = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.progressBarTrack = new System.Windows.Forms.ProgressBar();
            this.pictureBoxRepeat = new System.Windows.Forms.PictureBox();
            this.pictureBoxMix = new System.Windows.Forms.PictureBox();
            this.listPlaylistView = new System.Windows.Forms.ListView();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrev = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.labelTimeTrack = new System.Windows.Forms.Label();
            this.labelNameTrack = new System.Windows.Forms.Label();
            this.timerTrack = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMainForm = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelDownload = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageTrack)).BeginInit();
            this.menuMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.statusStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImageTrack
            // 
            this.pictureBoxImageTrack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxImageTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxImageTrack.BackgroundImage")));
            this.pictureBoxImageTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageTrack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImageTrack.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxImageTrack.Name = "pictureBoxImageTrack";
            this.pictureBoxImageTrack.Size = new System.Drawing.Size(100, 89);
            this.pictureBoxImageTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageTrack.TabIndex = 0;
            this.pictureBoxImageTrack.TabStop = false;
            // 
            // menuMainForm
            // 
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.Size = new System.Drawing.Size(564, 24);
            this.menuMainForm.TabIndex = 4;
            this.menuMainForm.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(343, 71);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(151, 45);
            this.trackBarVolume.TabIndex = 5;
            // 
            // progressBarTrack
            // 
            this.progressBarTrack.Location = new System.Drawing.Point(256, 102);
            this.progressBarTrack.Name = "progressBarTrack";
            this.progressBarTrack.Size = new System.Drawing.Size(238, 14);
            this.progressBarTrack.TabIndex = 6;
            // 
            // pictureBoxRepeat
            // 
            this.pictureBoxRepeat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRepeat.Image")));
            this.pictureBoxRepeat.Location = new System.Drawing.Point(500, 83);
            this.pictureBoxRepeat.Name = "pictureBoxRepeat";
            this.pictureBoxRepeat.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRepeat.TabIndex = 7;
            this.pictureBoxRepeat.TabStop = false;
            this.pictureBoxRepeat.Click += new System.EventHandler(this.pictureBoxRepeat_Click);
            // 
            // pictureBoxMix
            // 
            this.pictureBoxMix.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMix.Image")));
            this.pictureBoxMix.Location = new System.Drawing.Point(529, 83);
            this.pictureBoxMix.Name = "pictureBoxMix";
            this.pictureBoxMix.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxMix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMix.TabIndex = 8;
            this.pictureBoxMix.TabStop = false;
            this.pictureBoxMix.Click += new System.EventHandler(this.pictureBoxMix_Click);
            // 
            // listPlaylistView
            // 
            this.listPlaylistView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listPlaylistView.CheckBoxes = true;
            this.listPlaylistView.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPlaylistView.Location = new System.Drawing.Point(0, 122);
            this.listPlaylistView.MultiSelect = false;
            this.listPlaylistView.Name = "listPlaylistView";
            this.listPlaylistView.Size = new System.Drawing.Size(564, 342);
            this.listPlaylistView.TabIndex = 9;
            this.listPlaylistView.UseCompatibleStateImageBehavior = false;
            this.listPlaylistView.View = System.Windows.Forms.View.List;
            this.listPlaylistView.SelectedIndexChanged += new System.EventHandler(this.listPlaylistView_SelectedIndexChanged);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlay.Image")));
            this.pictureBoxPlay.Location = new System.Drawing.Point(118, 83);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(38, 33);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlay.TabIndex = 10;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxPrev
            // 
            this.pictureBoxPrev.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrev.Image")));
            this.pictureBoxPrev.Location = new System.Drawing.Point(162, 83);
            this.pictureBoxPrev.Name = "pictureBoxPrev";
            this.pictureBoxPrev.Size = new System.Drawing.Size(38, 33);
            this.pictureBoxPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrev.TabIndex = 11;
            this.pictureBoxPrev.TabStop = false;
            this.pictureBoxPrev.Click += new System.EventHandler(this.pictureBoxPrev_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(206, 83);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(38, 33);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNext.TabIndex = 12;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // labelTimeTrack
            // 
            this.labelTimeTrack.AutoSize = true;
            this.labelTimeTrack.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeTrack.Location = new System.Drawing.Point(118, 27);
            this.labelTimeTrack.Name = "labelTimeTrack";
            this.labelTimeTrack.Size = new System.Drawing.Size(108, 47);
            this.labelTimeTrack.TabIndex = 13;
            this.labelTimeTrack.Text = "00:00";
            // 
            // labelNameTrack
            // 
            this.labelNameTrack.AutoSize = true;
            this.labelNameTrack.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTrack.Location = new System.Drawing.Point(256, 42);
            this.labelNameTrack.Name = "labelNameTrack";
            this.labelNameTrack.Size = new System.Drawing.Size(86, 19);
            this.labelNameTrack.TabIndex = 14;
            this.labelNameTrack.Text = "NameTrack";
            // 
            // timerTrack
            // 
            this.timerTrack.Interval = 1000;
            this.timerTrack.Tick += new System.EventHandler(this.timerTrack_Tick);
            // 
            // notifyIconMainForm
            // 
            this.notifyIconMainForm.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconMainForm.BalloonTipTitle = "Status";
            this.notifyIconMainForm.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMainForm.Icon")));
            this.notifyIconMainForm.Text = "Music Surfer";
            this.notifyIconMainForm.Visible = true;
            this.notifyIconMainForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIconMainForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelDownload
            // 
            this.toolStripStatusLabelDownload.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelDownload.Name = "toolStripStatusLabelDownload";
            this.toolStripStatusLabelDownload.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabelDownload.Text = "Download Status:";
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.AllowMerge = false;
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabelDownload});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 467);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(564, 22);
            this.statusStripMainForm.TabIndex = 1;
            this.statusStripMainForm.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(564, 489);
            this.Controls.Add(this.labelNameTrack);
            this.Controls.Add(this.labelTimeTrack);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxPrev);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.listPlaylistView);
            this.Controls.Add(this.pictureBoxMix);
            this.Controls.Add(this.pictureBoxRepeat);
            this.Controls.Add(this.progressBarTrack);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuMainForm);
            this.Controls.Add(this.pictureBoxImageTrack);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMainForm;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Text = "Music Surfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageTrack)).EndInit();
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageTrack;
        private System.Windows.Forms.MenuStrip menuMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ProgressBar progressBarTrack;
        private System.Windows.Forms.PictureBox pictureBoxRepeat;
        private System.Windows.Forms.PictureBox pictureBoxMix;
        private System.Windows.Forms.ListView listPlaylistView;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxPrev;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Label labelTimeTrack;
        private System.Windows.Forms.Label labelNameTrack;
        private System.Windows.Forms.Timer timerTrack;
        private System.Windows.Forms.NotifyIcon notifyIconMainForm;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDownload;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
    }
}

