﻿
namespace DnDGame
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.CharacterBuilder = new System.Windows.Forms.Button();
            this.Crafting = new System.Windows.Forms.Button();
            this.Gathering = new System.Windows.Forms.Button();
            this.Looting = new System.Windows.Forms.Button();
            this.SaveGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharacterBuilder
            // 
            this.CharacterBuilder.BackColor = System.Drawing.Color.Transparent;
            this.CharacterBuilder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterBuilder.BackgroundImage")));
            this.CharacterBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CharacterBuilder.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CharacterBuilder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CharacterBuilder.Location = new System.Drawing.Point(12, 12);
            this.CharacterBuilder.Name = "CharacterBuilder";
            this.CharacterBuilder.Size = new System.Drawing.Size(438, 118);
            this.CharacterBuilder.TabIndex = 0;
            this.CharacterBuilder.Text = "Build Character";
            this.CharacterBuilder.UseVisualStyleBackColor = false;
            this.CharacterBuilder.Click += new System.EventHandler(this.CharacterBuilder_Click);
            // 
            // Crafting
            // 
            this.Crafting.BackColor = System.Drawing.Color.Transparent;
            this.Crafting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Crafting.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Crafting.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Crafting.Location = new System.Drawing.Point(12, 149);
            this.Crafting.Name = "Crafting";
            this.Crafting.Size = new System.Drawing.Size(438, 121);
            this.Crafting.TabIndex = 1;
            this.Crafting.Text = "Crafting";
            this.Crafting.UseVisualStyleBackColor = false;
            this.Crafting.Click += new System.EventHandler(this.Crafting_Click);
            // 
            // Gathering
            // 
            this.Gathering.BackColor = System.Drawing.Color.Transparent;
            this.Gathering.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gathering.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gathering.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Gathering.Location = new System.Drawing.Point(12, 294);
            this.Gathering.Name = "Gathering";
            this.Gathering.Size = new System.Drawing.Size(438, 116);
            this.Gathering.TabIndex = 2;
            this.Gathering.Text = "Gathering";
            this.Gathering.UseVisualStyleBackColor = false;
            this.Gathering.Click += new System.EventHandler(this.Gathering_Click);
            // 
            // Looting
            // 
            this.Looting.BackColor = System.Drawing.Color.Transparent;
            this.Looting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Looting.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Looting.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Looting.Location = new System.Drawing.Point(12, 432);
            this.Looting.Name = "Looting";
            this.Looting.Size = new System.Drawing.Size(438, 114);
            this.Looting.TabIndex = 3;
            this.Looting.Text = "Looting";
            this.Looting.UseVisualStyleBackColor = false;
            this.Looting.Click += new System.EventHandler(this.Looting_Click);
            // 
            // SaveGame
            // 
            this.SaveGame.BackColor = System.Drawing.Color.Transparent;
            this.SaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveGame.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SaveGame.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveGame.Location = new System.Drawing.Point(12, 574);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(438, 126);
            this.SaveGame.TabIndex = 4;
            this.SaveGame.Text = "Save Game";
            this.SaveGame.UseVisualStyleBackColor = false;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 1107);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.Looting);
            this.Controls.Add(this.Gathering);
            this.Controls.Add(this.Crafting);
            this.Controls.Add(this.CharacterBuilder);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CharacterBuilder;
        private System.Windows.Forms.Button Crafting;
        private System.Windows.Forms.Button Gathering;
        private System.Windows.Forms.Button Looting;
        private System.Windows.Forms.Button SaveGame;
    }
}