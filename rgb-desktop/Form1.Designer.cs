namespace LedTrialApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.redSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.greenSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.blueSlider = new System.Windows.Forms.TrackBar();
            this.redlbl = new System.Windows.Forms.Label();
            this.greenlbl = new System.Windows.Forms.Label();
            this.bluelbl = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.AnimationCombo = new System.Windows.Forms.ComboBox();
            this.flashCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comport = new System.Windows.Forms.TextBox();
            this.rgbBox = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Red";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Green";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Blue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rainbow";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "White";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(40, 157);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(482, 45);
            this.redSlider.TabIndex = 5;
            this.redSlider.ValueChanged += new System.EventHandler(this.redSlider_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "green";
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(46, 205);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(482, 45);
            this.greenSlider.TabIndex = 9;
            this.greenSlider.ValueChanged += new System.EventHandler(this.greenSlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "blue";
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(40, 256);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(482, 45);
            this.blueSlider.TabIndex = 11;
            this.blueSlider.ValueChanged += new System.EventHandler(this.blueSlider_ValueChanged);
            // 
            // redlbl
            // 
            this.redlbl.AutoSize = true;
            this.redlbl.Location = new System.Drawing.Point(506, 178);
            this.redlbl.Name = "redlbl";
            this.redlbl.Size = new System.Drawing.Size(13, 13);
            this.redlbl.TabIndex = 13;
            this.redlbl.Text = "0";
            this.redlbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // greenlbl
            // 
            this.greenlbl.AutoSize = true;
            this.greenlbl.Location = new System.Drawing.Point(506, 223);
            this.greenlbl.Name = "greenlbl";
            this.greenlbl.Size = new System.Drawing.Size(13, 13);
            this.greenlbl.TabIndex = 14;
            this.greenlbl.Text = "0";
            this.greenlbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bluelbl
            // 
            this.bluelbl.AutoSize = true;
            this.bluelbl.Location = new System.Drawing.Point(506, 275);
            this.bluelbl.Name = "bluelbl";
            this.bluelbl.Size = new System.Drawing.Size(13, 13);
            this.bluelbl.TabIndex = 15;
            this.bluelbl.Text = "0";
            this.bluelbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(364, 307);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 16;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // AnimationCombo
            // 
            this.AnimationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimationCombo.FormattingEnabled = true;
            this.AnimationCombo.Items.AddRange(new object[] {
            "None",
            "Chaser",
            "Rainbow",
            "Random white flash"});
            this.AnimationCombo.Location = new System.Drawing.Point(96, 41);
            this.AnimationCombo.Name = "AnimationCombo";
            this.AnimationCombo.Size = new System.Drawing.Size(425, 21);
            this.AnimationCombo.TabIndex = 17;
            // 
            // flashCheckbox
            // 
            this.flashCheckbox.AutoSize = true;
            this.flashCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.flashCheckbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.flashCheckbox.Location = new System.Drawing.Point(106, 75);
            this.flashCheckbox.Name = "flashCheckbox";
            this.flashCheckbox.Size = new System.Drawing.Size(175, 18);
            this.flashCheckbox.TabIndex = 18;
            this.flashCheckbox.Text = "Enable random Flashing effect";
            this.flashCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Animation:";
            // 
            // comport
            // 
            this.comport.Location = new System.Drawing.Point(497, 12);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(25, 20);
            this.comport.TabIndex = 20;
            this.comport.Text = "6";
            this.comport.TextChanged += new System.EventHandler(this.comport_TextChanged);
            // 
            // rgbBox
            // 
            this.rgbBox.BackColor = System.Drawing.Color.Black;
            this.rgbBox.Location = new System.Drawing.Point(421, 68);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.Size = new System.Drawing.Size(100, 83);
            this.rgbBox.TabIndex = 21;
            this.rgbBox.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(447, 307);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "myNotifyIcon";
            this.myNotifyIcon.Visible = true;
            this.myNotifyIcon.DoubleClick += new System.EventHandler(this.myNotifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(534, 348);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rgbBox);
            this.Controls.Add(this.comport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flashCheckbox);
            this.Controls.Add(this.AnimationCombo);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.bluelbl);
            this.Controls.Add(this.greenlbl);
            this.Controls.Add(this.redlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blueSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greenSlider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redSlider);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LED Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar redSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar greenSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar blueSlider;
        private System.Windows.Forms.Label redlbl;
        private System.Windows.Forms.Label greenlbl;
        private System.Windows.Forms.Label bluelbl;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ComboBox AnimationCombo;
        private System.Windows.Forms.CheckBox flashCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comport;
        private System.Windows.Forms.PictureBox rgbBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

