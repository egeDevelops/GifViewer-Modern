using GIF_Viewer.Controls;

namespace GIF_Viewer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFrame = new System.Windows.Forms.Label();
            this.cb_useMinFrameInterval = new System.Windows.Forms.CheckBox();
            this.fileFormatWarningImage = new System.Windows.Forms.PictureBox();
            this.nud_minFrameInterval = new System.Windows.Forms.NumericUpDown();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.btn_configuration = new System.Windows.Forms.Button();
            this.cms_gifRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoading = new System.Windows.Forms.Label();
            this.tt_mainTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_gif = new GIF_Viewer.CPictureBox();
            this.tlc_timeline = new GIF_Viewer.Controls.TimelineControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileFormatWarningImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minFrameInterval)).BeginInit();
            this.cms_gifRightClick.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lblFrame);
            this.panel1.Controls.Add(this.tlc_timeline);
            this.panel1.Controls.Add(this.cb_useMinFrameInterval);
            this.panel1.Controls.Add(this.fileFormatWarningImage);
            this.panel1.Controls.Add(this.nud_minFrameInterval);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Controls.Add(this.btn_configuration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 50);
            this.panel1.TabIndex = 1;
            // 
            // lblFrame
            // 
            this.lblFrame.AutoSize = true;
            this.lblFrame.BackColor = System.Drawing.Color.Transparent;
            this.lblFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFrame.Location = new System.Drawing.Point(3, 30);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(49, 15);
            this.lblFrame.TabIndex = 2;
            this.lblFrame.Text = "Frame: ";
            this.lblFrame.Click += new System.EventHandler(this.lblFrame_Click);
            // 
            // cb_useMinFrameInterval
            // 
            this.cb_useMinFrameInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_useMinFrameInterval.AutoSize = true;
            this.cb_useMinFrameInterval.Checked = true;
            this.cb_useMinFrameInterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_useMinFrameInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_useMinFrameInterval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_useMinFrameInterval.Location = new System.Drawing.Point(386, 5);
            this.cb_useMinFrameInterval.Name = "cb_useMinFrameInterval";
            this.cb_useMinFrameInterval.Size = new System.Drawing.Size(92, 19);
            this.cb_useMinFrameInterval.TabIndex = 5;
            this.cb_useMinFrameInterval.Text = "Use Min ms";
            this.cb_useMinFrameInterval.UseVisualStyleBackColor = true;
            this.cb_useMinFrameInterval.CheckedChanged += new System.EventHandler(this.cb_useMinFrameInterval_CheckedChanged);
            // 
            // fileFormatWarningImage
            // 
            this.fileFormatWarningImage.BackColor = System.Drawing.Color.Transparent;
            this.fileFormatWarningImage.Image = global::GIF_Viewer.Properties.Resources.emblem_important;
            this.fileFormatWarningImage.Location = new System.Drawing.Point(6, 7);
            this.fileFormatWarningImage.Name = "fileFormatWarningImage";
            this.fileFormatWarningImage.Size = new System.Drawing.Size(16, 16);
            this.fileFormatWarningImage.TabIndex = 3;
            this.fileFormatWarningImage.TabStop = false;
            this.tt_mainTooltip.SetToolTip(this.fileFormatWarningImage, "This image  is not in a .GIF file format!");
            this.fileFormatWarningImage.Visible = false;
            // 
            // nud_minFrameInterval
            // 
            this.nud_minFrameInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_minFrameInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nud_minFrameInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_minFrameInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_minFrameInterval.ForeColor = System.Drawing.SystemColors.Info;
            this.nud_minFrameInterval.Location = new System.Drawing.Point(386, 25);
            this.nud_minFrameInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_minFrameInterval.Name = "nud_minFrameInterval";
            this.nud_minFrameInterval.Size = new System.Drawing.Size(50, 22);
            this.nud_minFrameInterval.TabIndex = 4;
            this.nud_minFrameInterval.ValueChanged += new System.EventHandler(this.nud_minFrameInterval_ValueChanged);
            this.nud_minFrameInterval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_minFrameInterval_KeyUp);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.PlayBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.Color.White;
            this.PlayBtn.Location = new System.Drawing.Point(3, 3);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(66, 24);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "&Stop";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // btn_configuration
            // 
            this.btn_configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_configuration.AutoSize = true;
            this.btn_configuration.BackColor = System.Drawing.Color.Transparent;
            this.btn_configuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_configuration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_configuration.FlatAppearance.BorderSize = 0;
            this.btn_configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuration.Image = global::GIF_Viewer.Properties.Resources.applications_system;
            this.btn_configuration.Location = new System.Drawing.Point(442, 24);
            this.btn_configuration.Name = "btn_configuration";
            this.btn_configuration.Size = new System.Drawing.Size(33, 22);
            this.btn_configuration.TabIndex = 7;
            this.tt_mainTooltip.SetToolTip(this.btn_configuration, "Configurations");
            this.btn_configuration.UseVisualStyleBackColor = false;
            this.btn_configuration.Click += new System.EventHandler(this.btn_configuration_Click);
            // 
            // cms_gifRightClick
            // 
            this.cms_gifRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWithToolStripMenuItem});
            this.cms_gifRightClick.Name = "contextMenuStrip1";
            this.cms_gifRightClick.Size = new System.Drawing.Size(141, 26);
            this.cms_gifRightClick.Opening += new System.ComponentModel.CancelEventHandler(this.cms_gifRightClick_Opening);
            this.cms_gifRightClick.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_gifRightClick_ItemClicked);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openWithToolStripMenuItem.Text = "Open With...";
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Location = new System.Drawing.Point(0, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(484, 412);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pb_gif);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 412);
            this.panel2.TabIndex = 3;
            // 
            // pb_gif
            // 
            this.pb_gif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pb_gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_gif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_gif.Location = new System.Drawing.Point(0, 0);
            this.pb_gif.Name = "pb_gif";
            this.pb_gif.Size = new System.Drawing.Size(484, 412);
            this.pb_gif.TabIndex = 0;
            this.pb_gif.TabStop = false;
            this.pb_gif.Click += new System.EventHandler(this.pb_gif_Click);
            this.pb_gif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_gif_MouseDown);
            // 
            // tlc_timeline
            // 
            this.tlc_timeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlc_timeline.BehaviorType = GIF_Viewer.Controls.TimelineBehaviorType.Timeline;
            this.tlc_timeline.CurrentFrame = 1;
            this.tlc_timeline.DisplayFrameUnderMouse = true;
            this.tlc_timeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlc_timeline.FrameDisplayType = GIF_Viewer.Controls.TimelineFrameDisplayType.FrameNumber;
            this.tlc_timeline.Location = new System.Drawing.Point(75, 4);
            this.tlc_timeline.Maximum = 10;
            this.tlc_timeline.Minimum = 1;
            this.tlc_timeline.Name = "tlc_timeline";
            this.tlc_timeline.Range = new System.Drawing.Point(1, 9);
            this.tlc_timeline.ScrollScaleWidth = 1D;
            this.tlc_timeline.ScrollX = 0D;
            this.tlc_timeline.Size = new System.Drawing.Size(305, 43);
            this.tlc_timeline.TabIndex = 6;
            this.tlc_timeline.Text = "timelineControl1";
            this.tlc_timeline.TimelineHeight = 15;
            this.tlc_timeline.RangeChanged += new GIF_Viewer.Controls.TimelineControl.RangeChangedEventHandler(this.tlc_timeline_RangeChanged);
            this.tlc_timeline.FrameChanged += new GIF_Viewer.Controls.TimelineControl.FrameChangedEventHandler(this.tlc_timeline_FrameChanged);
            // 
            // FormMain
            // 
            this.AcceptButton = this.PlayBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 95);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF Viewer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileFormatWarningImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minFrameInterval)).EndInit();
            this.cms_gifRightClick.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CPictureBox pb_gif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.NumericUpDown nud_minFrameInterval;
        private System.Windows.Forms.CheckBox cb_useMinFrameInterval;
        private System.Windows.Forms.ContextMenuStrip cms_gifRightClick;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ToolTip tt_mainTooltip;
        private TimelineControl tlc_timeline;
        private System.Windows.Forms.Button btn_configuration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox fileFormatWarningImage;
    }
}

