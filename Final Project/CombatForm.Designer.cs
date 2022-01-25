using System;
using System.IO;

namespace DnDGame
{
    partial class CombatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrc = new System.Windows.Forms.PictureBox();
            this.pictureBoxGoblin = new System.Windows.Forms.PictureBox();
            this.pictureBoxZombie = new System.Windows.Forms.PictureBox();
            this.pictureBoxElf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoblin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElf)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 1012);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Attack";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(209, 1013);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alternate Attack";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(403, 1012);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "Off Hand Attack";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.Location = new System.Drawing.Point(586, 1012);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "Retreat";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 20F);
            this.MainTextBox.Location = new System.Drawing.Point(12, 543);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(759, 447);
            this.MainTextBox.TabIndex = 4;
            this.MainTextBox.Text = "";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 40F);
            this.button5.Location = new System.Drawing.Point(294, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 94);
            this.button5.TabIndex = 6;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStart.BackgroundImage")));
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStart.Location = new System.Drawing.Point(-9, 1);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(796, 1110);
            this.pictureBoxStart.TabIndex = 7;
            this.pictureBoxStart.TabStop = false;
            // 
            // pictureBoxOrc
            // 
            this.pictureBoxOrc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrc.BackgroundImage")));
            this.pictureBoxOrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOrc.Location = new System.Drawing.Point(12, 10);
            this.pictureBoxOrc.Name = "pictureBoxOrc";
            this.pictureBoxOrc.Size = new System.Drawing.Size(759, 526);
            this.pictureBoxOrc.TabIndex = 8;
            this.pictureBoxOrc.TabStop = false;
            this.pictureBoxOrc.Visible = false;
            // 
            // pictureBoxGoblin
            // 
            this.pictureBoxGoblin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoblin.BackgroundImage")));
            this.pictureBoxGoblin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGoblin.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxGoblin.Name = "pictureBoxGoblin";
            this.pictureBoxGoblin.Size = new System.Drawing.Size(796, 523);
            this.pictureBoxGoblin.TabIndex = 9;
            this.pictureBoxGoblin.TabStop = false;
            this.pictureBoxGoblin.Visible = false;
            // 
            // pictureBoxZombie
            // 
            this.pictureBoxZombie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxZombie.BackgroundImage")));
            this.pictureBoxZombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxZombie.Location = new System.Drawing.Point(34, 10);
            this.pictureBoxZombie.Name = "pictureBoxZombie";
            this.pictureBoxZombie.Size = new System.Drawing.Size(795, 524);
            this.pictureBoxZombie.TabIndex = 10;
            this.pictureBoxZombie.TabStop = false;
            this.pictureBoxZombie.Visible = false;
            // 
            // pictureBoxElf
            // 
            this.pictureBoxElf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxElf.BackgroundImage")));
            this.pictureBoxElf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxElf.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxElf.Name = "pictureBoxElf";
            this.pictureBoxElf.Size = new System.Drawing.Size(794, 523);
            this.pictureBoxElf.TabIndex = 11;
            this.pictureBoxElf.TabStop = false;
            this.pictureBoxElf.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 1106);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxOrc);
            this.Controls.Add(this.pictureBoxGoblin);
            this.Controls.Add(this.pictureBoxZombie);
            this.Controls.Add(this.pictureBoxElf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoblin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.RichTextBox MainTextBox;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.PictureBox pictureBoxStart;
        public System.Windows.Forms.PictureBox pictureBoxOrc;
        public System.Windows.Forms.PictureBox pictureBoxGoblin;
        public System.Windows.Forms.PictureBox pictureBoxZombie;
        public System.Windows.Forms.PictureBox pictureBoxElf;
    }
}

