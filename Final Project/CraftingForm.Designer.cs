
namespace DnDGame
{
    partial class CraftingForm
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
            this.listCraftableItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnCraft = new System.Windows.Forms.Button();
            this.listInventoryWeapons = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listInventoryReagents = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInventoryItemDescription = new System.Windows.Forms.TextBox();
            this.txtItemCraftDescription = new System.Windows.Forms.TextBox();
            this.txtGameNarrative = new System.Windows.Forms.TextBox();
            this.txtRequiredReagents = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCraftableItems
            // 
            this.listCraftableItems.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCraftableItems.FormattingEnabled = true;
            this.listCraftableItems.ItemHeight = 18;
            this.listCraftableItems.Location = new System.Drawing.Point(490, 34);
            this.listCraftableItems.Name = "listCraftableItems";
            this.listCraftableItems.Size = new System.Drawing.Size(162, 400);
            this.listCraftableItems.TabIndex = 0;
            this.listCraftableItems.SelectedIndexChanged += new System.EventHandler(this.listCraftableItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Craft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gold :";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(74, 393);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(19, 22);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "0";
            // 
            // btnCraft
            // 
            this.btnCraft.Location = new System.Drawing.Point(12, 386);
            this.btnCraft.Name = "btnCraft";
            this.btnCraft.Size = new System.Drawing.Size(472, 48);
            this.btnCraft.TabIndex = 6;
            this.btnCraft.Text = "Craft";
            this.btnCraft.UseVisualStyleBackColor = true;
            this.btnCraft.Click += new System.EventHandler(this.btnCraft_Click);
            // 
            // listInventoryWeapons
            // 
            this.listInventoryWeapons.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInventoryWeapons.FormattingEnabled = true;
            this.listInventoryWeapons.ItemHeight = 17;
            this.listInventoryWeapons.Location = new System.Drawing.Point(6, 39);
            this.listInventoryWeapons.Name = "listInventoryWeapons";
            this.listInventoryWeapons.Size = new System.Drawing.Size(150, 157);
            this.listInventoryWeapons.TabIndex = 7;
            this.listInventoryWeapons.SelectedIndexChanged += new System.EventHandler(this.listInventoryWeapons_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weapons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reagents";
            // 
            // listInventoryReagents
            // 
            this.listInventoryReagents.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInventoryReagents.FormattingEnabled = true;
            this.listInventoryReagents.ItemHeight = 17;
            this.listInventoryReagents.Location = new System.Drawing.Point(6, 217);
            this.listInventoryReagents.Name = "listInventoryReagents";
            this.listInventoryReagents.Size = new System.Drawing.Size(150, 157);
            this.listInventoryReagents.TabIndex = 9;
            this.listInventoryReagents.SelectedIndexChanged += new System.EventHandler(this.listInventoryReagents_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGold);
            this.groupBox1.Controls.Add(this.txtInventoryItemDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listInventoryReagents);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listInventoryWeapons);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(658, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 425);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // txtInventoryItemDescription
            // 
            this.txtInventoryItemDescription.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryItemDescription.ForeColor = System.Drawing.Color.Black;
            this.txtInventoryItemDescription.Location = new System.Drawing.Point(162, 39);
            this.txtInventoryItemDescription.Multiline = true;
            this.txtInventoryItemDescription.Name = "txtInventoryItemDescription";
            this.txtInventoryItemDescription.ReadOnly = true;
            this.txtInventoryItemDescription.Size = new System.Drawing.Size(189, 335);
            this.txtInventoryItemDescription.TabIndex = 12;
            this.txtInventoryItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemCraftDescription
            // 
            this.txtItemCraftDescription.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCraftDescription.Location = new System.Drawing.Point(295, 12);
            this.txtItemCraftDescription.Multiline = true;
            this.txtItemCraftDescription.Name = "txtItemCraftDescription";
            this.txtItemCraftDescription.ReadOnly = true;
            this.txtItemCraftDescription.Size = new System.Drawing.Size(189, 160);
            this.txtItemCraftDescription.TabIndex = 13;
            this.txtItemCraftDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGameNarrative
            // 
            this.txtGameNarrative.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameNarrative.Location = new System.Drawing.Point(12, 12);
            this.txtGameNarrative.Multiline = true;
            this.txtGameNarrative.Name = "txtGameNarrative";
            this.txtGameNarrative.ReadOnly = true;
            this.txtGameNarrative.Size = new System.Drawing.Size(277, 368);
            this.txtGameNarrative.TabIndex = 15;
            // 
            // txtRequiredReagents
            // 
            this.txtRequiredReagents.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredReagents.Location = new System.Drawing.Point(295, 178);
            this.txtRequiredReagents.Multiline = true;
            this.txtRequiredReagents.Name = "txtRequiredReagents";
            this.txtRequiredReagents.ReadOnly = true;
            this.txtRequiredReagents.Size = new System.Drawing.Size(189, 202);
            this.txtRequiredReagents.TabIndex = 16;
            this.txtRequiredReagents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 440);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(472, 30);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CraftingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 477);
            this.ControlBox = false;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtRequiredReagents);
            this.Controls.Add(this.txtGameNarrative);
            this.Controls.Add(this.txtItemCraftDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCraft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCraftableItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CraftingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craft";
            this.Activated += new System.EventHandler(this.CraftingForm_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCraftableItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnCraft;
        private System.Windows.Forms.ListBox listInventoryWeapons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listInventoryReagents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInventoryItemDescription;
        private System.Windows.Forms.TextBox txtItemCraftDescription;
        private System.Windows.Forms.TextBox txtGameNarrative;
        private System.Windows.Forms.TextBox txtRequiredReagents;
        private System.Windows.Forms.Button btnHome;
    }
}