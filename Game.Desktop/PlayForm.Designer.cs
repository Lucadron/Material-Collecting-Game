namespace Game.Desktop
{
    partial class PlayForm
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.collectorPanel = new System.Windows.Forms.Panel();
            this.collectAreaPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(983, 60);
            this.infoPanel.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(3, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(302, 26);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Başlamak için Enter\'e basınız.";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(871, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 48);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "0:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // collectorPanel
            // 
            this.collectorPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.collectorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.collectorPanel.Location = new System.Drawing.Point(0, 547);
            this.collectorPanel.Name = "collectorPanel";
            this.collectorPanel.Size = new System.Drawing.Size(983, 80);
            this.collectorPanel.TabIndex = 1;
            // 
            // collectAreaPanel
            // 
            this.collectAreaPanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.collectAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectAreaPanel.Location = new System.Drawing.Point(0, 60);
            this.collectAreaPanel.Name = "collectAreaPanel";
            this.collectAreaPanel.Size = new System.Drawing.Size(983, 487);
            this.collectAreaPanel.TabIndex = 2;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 627);
            this.Controls.Add(this.collectAreaPanel);
            this.Controls.Add(this.collectorPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyDown);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel collectorPanel;
        private System.Windows.Forms.Panel collectAreaPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}