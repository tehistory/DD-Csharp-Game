
namespace DnDGame
{
    partial class CraftRoll
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
            this.lblCraftItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRollToCraft = new System.Windows.Forms.Button();
            this.btnCancelCraft = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuccessRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCraftItemName
            // 
            this.lblCraftItemName.AutoSize = true;
            this.lblCraftItemName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCraftItemName.Location = new System.Drawing.Point(12, 9);
            this.lblCraftItemName.Name = "lblCraftItemName";
            this.lblCraftItemName.Size = new System.Drawing.Size(248, 18);
            this.lblCraftItemName.TabIndex = 0;
            this.lblCraftItemName.Text = "You are attempting to craft an item.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do you wish to continue?";
            // 
            // btnRollToCraft
            // 
            this.btnRollToCraft.Location = new System.Drawing.Point(15, 95);
            this.btnRollToCraft.Name = "btnRollToCraft";
            this.btnRollToCraft.Size = new System.Drawing.Size(119, 32);
            this.btnRollToCraft.TabIndex = 2;
            this.btnRollToCraft.Text = "Roll";
            this.btnRollToCraft.UseVisualStyleBackColor = true;
            this.btnRollToCraft.Click += new System.EventHandler(this.btnRollToCraft_Click);
            // 
            // btnCancelCraft
            // 
            this.btnCancelCraft.Location = new System.Drawing.Point(146, 95);
            this.btnCancelCraft.Name = "btnCancelCraft";
            this.btnCancelCraft.Size = new System.Drawing.Size(119, 32);
            this.btnCancelCraft.TabIndex = 3;
            this.btnCancelCraft.Text = "Cancel";
            this.btnCancelCraft.UseVisualStyleBackColor = true;
            this.btnCancelCraft.Click += new System.EventHandler(this.btnCancelCraft_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Success Rate :";
            // 
            // lblSuccessRate
            // 
            this.lblSuccessRate.AutoSize = true;
            this.lblSuccessRate.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessRate.Location = new System.Drawing.Point(87, 58);
            this.lblSuccessRate.Name = "lblSuccessRate";
            this.lblSuccessRate.Size = new System.Drawing.Size(13, 15);
            this.lblSuccessRate.TabIndex = 5;
            this.lblSuccessRate.Text = "0";
            // 
            // CraftRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 139);
            this.ControlBox = false;
            this.Controls.Add(this.lblSuccessRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelCraft);
            this.Controls.Add(this.btnRollToCraft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCraftItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CraftRoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CraftRoll";
            this.Load += new System.EventHandler(this.CraftRoll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCraftItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRollToCraft;
        private System.Windows.Forms.Button btnCancelCraft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSuccessRate;
    }
}