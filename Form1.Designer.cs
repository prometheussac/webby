namespace WebbTelescope
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.goldPanels = new System.Windows.Forms.PictureBox();
            this.focusKnob = new System.Windows.Forms.PictureBox();
            this.panelHolder = new System.Windows.Forms.PictureBox();
            this.starTracker = new System.Windows.Forms.PictureBox();
            this.spaceCraft = new System.Windows.Forms.PictureBox();
            this.solarShield = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goldPanels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceCraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarShield)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // goldPanels
            // 
            this.goldPanels.BackColor = System.Drawing.Color.Transparent;
            this.goldPanels.Image = global::WebbTelescope.Properties.Resources._31;
            this.goldPanels.InitialImage = ((System.Drawing.Image)(resources.GetObject("goldPanels.InitialImage")));
            this.goldPanels.Location = new System.Drawing.Point(339, 12);
            this.goldPanels.Name = "goldPanels";
            this.goldPanels.Size = new System.Drawing.Size(178, 331);
            this.goldPanels.TabIndex = 0;
            this.goldPanels.TabStop = false;
            this.goldPanels.Click += new System.EventHandler(this.goldPanels_Click);
            this.goldPanels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.goldPanels.MouseMove += new System.Windows.Forms.MouseEventHandler(this.goldPanels_MouseMove);
            // 
            // focusKnob
            // 
            this.focusKnob.BackColor = System.Drawing.Color.Transparent;
            this.focusKnob.Image = global::WebbTelescope.Properties.Resources.djjdd;
            this.focusKnob.InitialImage = ((System.Drawing.Image)(resources.GetObject("focusKnob.InitialImage")));
            this.focusKnob.Location = new System.Drawing.Point(-19, 12);
            this.focusKnob.Name = "focusKnob";
            this.focusKnob.Size = new System.Drawing.Size(281, 290);
            this.focusKnob.TabIndex = 7;
            this.focusKnob.TabStop = false;
            this.focusKnob.Click += new System.EventHandler(this.focusKnob_Click);
            this.focusKnob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.focusKnob.MouseMove += new System.Windows.Forms.MouseEventHandler(this.focusKnob_MouseMove);
            // 
            // panelHolder
            // 
            this.panelHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelHolder.Image = global::WebbTelescope.Properties.Resources._21;
            this.panelHolder.InitialImage = null;
            this.panelHolder.Location = new System.Drawing.Point(603, 25);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(59, 253);
            this.panelHolder.TabIndex = 6;
            this.panelHolder.TabStop = false;
            this.panelHolder.Click += new System.EventHandler(this.panelHolder_Click);
            this.panelHolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.panelHolder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHolder_MouseMove);
            // 
            // starTracker
            // 
            this.starTracker.BackColor = System.Drawing.Color.Transparent;
            this.starTracker.Image = global::WebbTelescope.Properties.Resources._672;
            this.starTracker.InitialImage = ((System.Drawing.Image)(resources.GetObject("starTracker.InitialImage")));
            this.starTracker.Location = new System.Drawing.Point(603, 537);
            this.starTracker.Name = "starTracker";
            this.starTracker.Size = new System.Drawing.Size(29, 22);
            this.starTracker.TabIndex = 5;
            this.starTracker.TabStop = false;
            this.starTracker.Click += new System.EventHandler(this.starTracker_Click);
            this.starTracker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.starTracker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.starTracker_MouseMove);
            // 
            // spaceCraft
            // 
            this.spaceCraft.BackColor = System.Drawing.Color.Transparent;
            this.spaceCraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spaceCraft.ErrorImage = null;
            this.spaceCraft.Image = global::WebbTelescope.Properties.Resources.image1;
            this.spaceCraft.InitialImage = null;
            this.spaceCraft.Location = new System.Drawing.Point(686, 502);
            this.spaceCraft.Name = "spaceCraft";
            this.spaceCraft.Size = new System.Drawing.Size(90, 77);
            this.spaceCraft.TabIndex = 4;
            this.spaceCraft.TabStop = false;
            this.spaceCraft.Click += new System.EventHandler(this.spaceCraft_Click);
            this.spaceCraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.spaceCraft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spaceCraft_MouseMove);
            // 
            // solarShield
            // 
            this.solarShield.BackColor = System.Drawing.Color.Transparent;
            this.solarShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.solarShield.Image = global::WebbTelescope.Properties.Resources.ov123;
            this.solarShield.InitialImage = null;
            this.solarShield.Location = new System.Drawing.Point(282, 238);
            this.solarShield.Name = "solarShield";
            this.solarShield.Size = new System.Drawing.Size(788, 361);
            this.solarShield.TabIndex = 3;
            this.solarShield.TabStop = false;
            this.solarShield.Click += new System.EventHandler(this.solarShield_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.DarkSlateGray;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("SimSun-ExtB", 12F);
            this.info.ForeColor = System.Drawing.SystemColors.Info;
            this.info.Location = new System.Drawing.Point(966, 45);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(364, 197);
            this.info.TabIndex = 10;
            this.info.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(962, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "SHORT INFO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(991, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1062, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mount Backplane ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1062, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Install Gold Plated Mirrors";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(1062, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Set Focus Knob";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(1062, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Connect SpaceCraft";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(1062, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Mount Star tracker";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(1062, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 31);
            this.button6.TabIndex = 18;
            this.button6.Text = "RETRY";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1096, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Double click to exit.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1342, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.goldPanels);
            this.Controls.Add(this.focusKnob);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.starTracker);
            this.Controls.Add(this.spaceCraft);
            this.Controls.Add(this.solarShield);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Webby";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_Close);
            ((System.ComponentModel.ISupportInitialize)(this.goldPanels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceCraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarShield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox goldPanels;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox solarShield;
        private System.Windows.Forms.PictureBox spaceCraft;
        private System.Windows.Forms.PictureBox starTracker;
        private System.Windows.Forms.PictureBox focusKnob;
        private System.Windows.Forms.PictureBox panelHolder;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

