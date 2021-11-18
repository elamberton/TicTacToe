namespace TicTacToe
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.OnePanel = new System.Windows.Forms.Panel();
            this.SevenPanel = new System.Windows.Forms.Panel();
            this.FivePanel = new System.Windows.Forms.Panel();
            this.TwoPanel = new System.Windows.Forms.Panel();
            this.SixPanel = new System.Windows.Forms.Panel();
            this.ThreePanel = new System.Windows.Forms.Panel();
            this.EightPanel = new System.Windows.Forms.Panel();
            this.FourPanel = new System.Windows.Forms.Panel();
            this.NinePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OnePanel
            // 
            this.OnePanel.Location = new System.Drawing.Point(5, 5);
            this.OnePanel.Name = "OnePanel";
            this.OnePanel.Size = new System.Drawing.Size(100, 100);
            this.OnePanel.TabIndex = 0;
            this.OnePanel.Tag = "0";
            this.OnePanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // SevenPanel
            // 
            this.SevenPanel.AllowDrop = true;
            this.SevenPanel.Location = new System.Drawing.Point(5, 225);
            this.SevenPanel.Name = "SevenPanel";
            this.SevenPanel.Size = new System.Drawing.Size(100, 100);
            this.SevenPanel.TabIndex = 0;
            this.SevenPanel.Tag = "6";
            this.SevenPanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // FivePanel
            // 
            this.FivePanel.AllowDrop = true;
            this.FivePanel.Location = new System.Drawing.Point(115, 115);
            this.FivePanel.Name = "FivePanel";
            this.FivePanel.Size = new System.Drawing.Size(100, 100);
            this.FivePanel.TabIndex = 0;
            this.FivePanel.Tag = "4";
            this.FivePanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // TwoPanel
            // 
            this.TwoPanel.AllowDrop = true;
            this.TwoPanel.Location = new System.Drawing.Point(115, 5);
            this.TwoPanel.Name = "TwoPanel";
            this.TwoPanel.Size = new System.Drawing.Size(100, 100);
            this.TwoPanel.TabIndex = 0;
            this.TwoPanel.Tag = "1";
            this.TwoPanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // SixPanel
            // 
            this.SixPanel.AllowDrop = true;
            this.SixPanel.Location = new System.Drawing.Point(225, 115);
            this.SixPanel.Name = "SixPanel";
            this.SixPanel.Size = new System.Drawing.Size(100, 100);
            this.SixPanel.TabIndex = 0;
            this.SixPanel.Tag = "5";
            this.SixPanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // ThreePanel
            // 
            this.ThreePanel.AllowDrop = true;
            this.ThreePanel.Location = new System.Drawing.Point(225, 5);
            this.ThreePanel.Name = "ThreePanel";
            this.ThreePanel.Size = new System.Drawing.Size(100, 100);
            this.ThreePanel.TabIndex = 0;
            this.ThreePanel.Tag = "2";
            this.ThreePanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // EightPanel
            // 
            this.EightPanel.AllowDrop = true;
            this.EightPanel.Location = new System.Drawing.Point(115, 225);
            this.EightPanel.Name = "EightPanel";
            this.EightPanel.Size = new System.Drawing.Size(100, 100);
            this.EightPanel.TabIndex = 0;
            this.EightPanel.Tag = "7";
            this.EightPanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // FourPanel
            // 
            this.FourPanel.AllowDrop = true;
            this.FourPanel.Location = new System.Drawing.Point(5, 115);
            this.FourPanel.Name = "FourPanel";
            this.FourPanel.Size = new System.Drawing.Size(100, 100);
            this.FourPanel.TabIndex = 0;
            this.FourPanel.Tag = "3";
            this.FourPanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // NinePanel
            // 
            this.NinePanel.AllowDrop = true;
            this.NinePanel.Location = new System.Drawing.Point(225, 225);
            this.NinePanel.Name = "NinePanel";
            this.NinePanel.Size = new System.Drawing.Size(100, 100);
            this.NinePanel.TabIndex = 0;
            this.NinePanel.Tag = "8";
            this.NinePanel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(330, 330);
            this.Controls.Add(this.EightPanel);
            this.Controls.Add(this.FivePanel);
            this.Controls.Add(this.SevenPanel);
            this.Controls.Add(this.SixPanel);
            this.Controls.Add(this.FourPanel);
            this.Controls.Add(this.ThreePanel);
            this.Controls.Add(this.NinePanel);
            this.Controls.Add(this.TwoPanel);
            this.Controls.Add(this.OnePanel);
            this.Name = "GameForm";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OnePanel;
        private System.Windows.Forms.Panel SevenPanel;
        private System.Windows.Forms.Panel FivePanel;
        private System.Windows.Forms.Panel TwoPanel;
        private System.Windows.Forms.Panel SixPanel;
        private System.Windows.Forms.Panel ThreePanel;
        private System.Windows.Forms.Panel EightPanel;
        private System.Windows.Forms.Panel FourPanel;
        private System.Windows.Forms.Panel NinePanel;
    }
}