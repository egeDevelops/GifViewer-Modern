namespace GIF_Viewer.Views
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_keyframeReach = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_keyframeReach = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_keyframeMemory = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_keyframeMemory = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bufferMemory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bufferMemory = new System.Windows.Forms.TrackBar();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_minimumFrameDelay = new System.Windows.Forms.NumericUpDown();
            this.cb_setMinimumDelay = new System.Windows.Forms.CheckBox();
            this.cb_allowMultipleInstances = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_keyframeReach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_keyframeMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bufferMemory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minimumFrameDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_keyframeReach);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_keyframeReach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_keyframeMemory);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_keyframeMemory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_bufferMemory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_bufferMemory);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memory";
            // 
            // lbl_keyframeReach
            // 
            this.lbl_keyframeReach.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keyframeReach.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_keyframeReach.Location = new System.Drawing.Point(18, 153);
            this.lbl_keyframeReach.Name = "lbl_keyframeReach";
            this.lbl_keyframeReach.Size = new System.Drawing.Size(109, 13);
            this.lbl_keyframeReach.TabIndex = 14;
            this.lbl_keyframeReach.Text = "100";
            this.lbl_keyframeReach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_keyframeReach.Click += new System.EventHandler(this.lbl_keyframeReach_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(489, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "100";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(142, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(18, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Maximum Keyframe Reach:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tb_keyframeReach
            // 
            this.tb_keyframeReach.LargeChange = 1;
            this.tb_keyframeReach.Location = new System.Drawing.Point(136, 121);
            this.tb_keyframeReach.Maximum = 100;
            this.tb_keyframeReach.Name = "tb_keyframeReach";
            this.tb_keyframeReach.Size = new System.Drawing.Size(378, 45);
            this.tb_keyframeReach.TabIndex = 10;
            this.tb_keyframeReach.Scroll += new System.EventHandler(this.tb_keyframeReach_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(476, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "512 MB";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(133, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "5 MB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_keyframeMemory
            // 
            this.lbl_keyframeMemory.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keyframeMemory.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_keyframeMemory.Location = new System.Drawing.Point(18, 102);
            this.lbl_keyframeMemory.Name = "lbl_keyframeMemory";
            this.lbl_keyframeMemory.Size = new System.Drawing.Size(109, 13);
            this.lbl_keyframeMemory.TabIndex = 7;
            this.lbl_keyframeMemory.Text = "100 MB";
            this.lbl_keyframeMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_keyframeMemory.Click += new System.EventHandler(this.lbl_keyframeMemory_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(18, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Available Memory For Keyframes:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_keyframeMemory
            // 
            this.tb_keyframeMemory.LargeChange = 1;
            this.tb_keyframeMemory.Location = new System.Drawing.Point(136, 70);
            this.tb_keyframeMemory.Maximum = 100;
            this.tb_keyframeMemory.Name = "tb_keyframeMemory";
            this.tb_keyframeMemory.Size = new System.Drawing.Size(378, 45);
            this.tb_keyframeMemory.TabIndex = 5;
            this.tb_keyframeMemory.Scroll += new System.EventHandler(this.tb_keyframeMemory_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(476, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "512 MB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(133, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "5 MB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_bufferMemory
            // 
            this.lbl_bufferMemory.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bufferMemory.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_bufferMemory.Location = new System.Drawing.Point(18, 51);
            this.lbl_bufferMemory.Name = "lbl_bufferMemory";
            this.lbl_bufferMemory.Size = new System.Drawing.Size(109, 13);
            this.lbl_bufferMemory.TabIndex = 2;
            this.lbl_bufferMemory.Text = "100 MB";
            this.lbl_bufferMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_bufferMemory.Click += new System.EventHandler(this.lbl_bufferMemory_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Buffer Memory:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_bufferMemory
            // 
            this.tb_bufferMemory.LargeChange = 1;
            this.tb_bufferMemory.Location = new System.Drawing.Point(136, 19);
            this.tb_bufferMemory.Maximum = 100;
            this.tb_bufferMemory.Name = "tb_bufferMemory";
            this.tb_bufferMemory.Size = new System.Drawing.Size(378, 45);
            this.tb_bufferMemory.TabIndex = 0;
            this.tb_bufferMemory.Scroll += new System.EventHandler(this.tb_bufferMemory_Scroll);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.Image = global::GIF_Viewer.Properties.Resources.action_check;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.Location = new System.Drawing.Point(360, 301);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(83, 30);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "&Ok";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.Brown;
            this.btn_cancel.Image = global::GIF_Viewer.Properties.Resources.action_delete1;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(449, 301);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 30);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nud_minimumFrameDelay);
            this.groupBox2.Controls.Add(this.cb_setMinimumDelay);
            this.groupBox2.Controls.Add(this.cb_allowMultipleInstances);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(469, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nud_minimumFrameDelay
            // 
            this.nud_minimumFrameDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nud_minimumFrameDelay.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_minimumFrameDelay.ForeColor = System.Drawing.Color.White;
            this.nud_minimumFrameDelay.Location = new System.Drawing.Point(394, 23);
            this.nud_minimumFrameDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_minimumFrameDelay.Name = "nud_minimumFrameDelay";
            this.nud_minimumFrameDelay.Size = new System.Drawing.Size(69, 22);
            this.nud_minimumFrameDelay.TabIndex = 2;
            this.nud_minimumFrameDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cb_setMinimumDelay
            // 
            this.cb_setMinimumDelay.AutoSize = true;
            this.cb_setMinimumDelay.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_setMinimumDelay.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_setMinimumDelay.Location = new System.Drawing.Point(173, 24);
            this.cb_setMinimumDelay.Name = "cb_setMinimumDelay";
            this.cb_setMinimumDelay.Size = new System.Drawing.Size(215, 19);
            this.cb_setMinimumDelay.TabIndex = 1;
            this.cb_setMinimumDelay.Text = "Set minimum frame delay on startup:";
            this.cb_setMinimumDelay.UseVisualStyleBackColor = true;
            this.cb_setMinimumDelay.CheckedChanged += new System.EventHandler(this.cb_setMinimumDelay_CheckedChanged);
            // 
            // cb_allowMultipleInstances
            // 
            this.cb_allowMultipleInstances.AutoSize = true;
            this.cb_allowMultipleInstances.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_allowMultipleInstances.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_allowMultipleInstances.Location = new System.Drawing.Point(18, 24);
            this.cb_allowMultipleInstances.Name = "cb_allowMultipleInstances";
            this.cb_allowMultipleInstances.Size = new System.Drawing.Size(149, 19);
            this.cb_allowMultipleInstances.TabIndex = 0;
            this.cb_allowMultipleInstances.Text = "Allow multiple instances";
            this.cb_allowMultipleInstances.UseVisualStyleBackColor = true;
            this.cb_allowMultipleInstances.CheckedChanged += new System.EventHandler(this.cb_allowMultipleInstances_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(544, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_keyframeReach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_keyframeMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bufferMemory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minimumFrameDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_bufferMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_bufferMemory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_keyframeMemory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tb_keyframeMemory;
        private System.Windows.Forms.Label lbl_keyframeReach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tb_keyframeReach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_allowMultipleInstances;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_minimumFrameDelay;
        private System.Windows.Forms.CheckBox cb_setMinimumDelay;
    }
}