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
            this.speedText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ledCounts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Red";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Green";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 86);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Blue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rainbow";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 158);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "White";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(53, 193);
            this.redSlider.Margin = new System.Windows.Forms.Padding(4);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(643, 56);
            this.redSlider.TabIndex = 5;
            this.redSlider.ValueChanged += new System.EventHandler(this.redSlider_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "green";
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(61, 252);
            this.greenSlider.Margin = new System.Windows.Forms.Padding(4);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(643, 56);
            this.greenSlider.TabIndex = 9;
            this.greenSlider.ValueChanged += new System.EventHandler(this.greenSlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "blue";
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(53, 315);
            this.blueSlider.Margin = new System.Windows.Forms.Padding(4);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(643, 56);
            this.blueSlider.TabIndex = 11;
            this.blueSlider.ValueChanged += new System.EventHandler(this.blueSlider_ValueChanged);
            // 
            // redlbl
            // 
            this.redlbl.AutoSize = true;
            this.redlbl.Location = new System.Drawing.Point(675, 219);
            this.redlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redlbl.Name = "redlbl";
            this.redlbl.Size = new System.Drawing.Size(14, 16);
            this.redlbl.TabIndex = 13;
            this.redlbl.Text = "0";
            this.redlbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // greenlbl
            // 
            this.greenlbl.AutoSize = true;
            this.greenlbl.Location = new System.Drawing.Point(675, 274);
            this.greenlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greenlbl.Name = "greenlbl";
            this.greenlbl.Size = new System.Drawing.Size(14, 16);
            this.greenlbl.TabIndex = 14;
            this.greenlbl.Text = "0";
            this.greenlbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bluelbl
            // 
            this.bluelbl.AutoSize = true;
            this.bluelbl.Location = new System.Drawing.Point(675, 338);
            this.bluelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bluelbl.Name = "bluelbl";
            this.bluelbl.Size = new System.Drawing.Size(14, 16);
            this.bluelbl.TabIndex = 15;
            this.bluelbl.Text = "0";
            this.bluelbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(485, 378);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
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
            this.AnimationCombo.Location = new System.Drawing.Point(128, 50);
            this.AnimationCombo.Margin = new System.Windows.Forms.Padding(4);
            this.AnimationCombo.Name = "AnimationCombo";
            this.AnimationCombo.Size = new System.Drawing.Size(565, 24);
            this.AnimationCombo.TabIndex = 17;
            // 
            // flashCheckbox
            // 
            this.flashCheckbox.AutoSize = true;
            this.flashCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.flashCheckbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.flashCheckbox.Location = new System.Drawing.Point(141, 92);
            this.flashCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.flashCheckbox.Name = "flashCheckbox";
            this.flashCheckbox.Size = new System.Drawing.Size(219, 21);
            this.flashCheckbox.TabIndex = 18;
            this.flashCheckbox.Text = "Enable random Flashing effect";
            this.flashCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Animation:";
            // 
            // comport
            // 
            this.comport.Location = new System.Drawing.Point(663, 15);
            this.comport.Margin = new System.Windows.Forms.Padding(4);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(32, 22);
            this.comport.TabIndex = 20;
            this.comport.Text = "5";
            this.comport.TextChanged += new System.EventHandler(this.comport_TextChanged);
            // 
            // rgbBox
            // 
            this.rgbBox.BackColor = System.Drawing.Color.Black;
            this.rgbBox.Location = new System.Drawing.Point(561, 84);
            this.rgbBox.Margin = new System.Windows.Forms.Padding(4);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.Size = new System.Drawing.Size(133, 102);
            this.rgbBox.TabIndex = 21;
            this.rgbBox.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(596, 378);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.myNotifyIcon.Text = "myNotifyIcon";
            this.myNotifyIcon.Visible = true;
            this.myNotifyIcon.DoubleClick += new System.EventHandler(this.myNotifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // speedText
            // 
            this.speedText.Location = new System.Drawing.Point(549, 15);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(59, 22);
            this.speedText.TabIndex = 23;
            this.speedText.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "COM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Led Count:";
            // 
            // ledCounts
            // 
            this.ledCounts.Location = new System.Drawing.Point(425, 15);
            this.ledCounts.Name = "ledCounts";
            this.ledCounts.Size = new System.Drawing.Size(59, 22);
            this.ledCounts.TabIndex = 27;
            this.ledCounts.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(712, 428);
            this.Controls.Add(this.ledCounts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speedText);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox speedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ledCounts;
    }
}

