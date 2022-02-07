
namespace DnDGame
{
    partial class GatheringForm
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
            this.pbGatheringImage = new System.Windows.Forms.PictureBox();
            this.cbGatheringSelect = new System.Windows.Forms.ComboBox();
            this.startGathering = new System.Windows.Forms.Button();
            this.infoLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGatheringImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGatheringImage
            // 
            this.pbGatheringImage.Enabled = false;
            this.pbGatheringImage.Location = new System.Drawing.Point(12, 39);
            this.pbGatheringImage.Name = "pbGatheringImage";
            this.pbGatheringImage.Size = new System.Drawing.Size(354, 233);
            this.pbGatheringImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGatheringImage.TabIndex = 0;
            this.pbGatheringImage.TabStop = false;
            this.pbGatheringImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbGatheringSelect
            // 
            this.cbGatheringSelect.FormattingEnabled = true;
            this.cbGatheringSelect.Items.AddRange(new object[] {
            "Forest",
            "Desert",
            "Grasslands",
            "Marsh",
            "Mountain"});
            this.cbGatheringSelect.Location = new System.Drawing.Point(130, 278);
            this.cbGatheringSelect.Name = "cbGatheringSelect";
            this.cbGatheringSelect.Size = new System.Drawing.Size(139, 21);
            this.cbGatheringSelect.TabIndex = 1;
            this.cbGatheringSelect.Text = "Select a Gathering Area";
            this.cbGatheringSelect.SelectedIndexChanged += new System.EventHandler(this.cbGatheringSelect_SelectedIndexChanged);
            // 
            // startGathering
            // 
            this.startGathering.Location = new System.Drawing.Point(12, 398);
            this.startGathering.Name = "startGathering";
            this.startGathering.Size = new System.Drawing.Size(88, 23);
            this.startGathering.TabIndex = 2;
            this.startGathering.Text = "Start Gathering";
            this.startGathering.UseVisualStyleBackColor = true;
            this.startGathering.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoLog
            // 
            this.infoLog.Location = new System.Drawing.Point(106, 325);
            this.infoLog.Multiline = true;
            this.infoLog.Name = "infoLog";
            this.infoLog.ReadOnly = true;
            this.infoLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoLog.Size = new System.Drawing.Size(260, 175);
            this.infoLog.TabIndex = 3;
            this.infoLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GatheringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 512);
            this.ControlBox = false;
            this.Controls.Add(this.infoLog);
            this.Controls.Add(this.startGathering);
            this.Controls.Add(this.cbGatheringSelect);
            this.Controls.Add(this.pbGatheringImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GatheringForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGatheringImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbGatheringImage;
        private System.Windows.Forms.ComboBox cbGatheringSelect;
        private System.Windows.Forms.Button startGathering;
        private System.Windows.Forms.TextBox infoLog;
    }
}

