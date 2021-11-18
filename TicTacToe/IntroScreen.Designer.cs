namespace TicTacToe
{
    partial class IntroScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroScreen));
            this.OrLabel = new System.Windows.Forms.Label();
            this.XButton = new System.Windows.Forms.Button();
            this.OButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrLabel.Location = new System.Drawing.Point(118, 84);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(193, 37);
            this.OrLabel.TabIndex = 0;
            this.OrLabel.Text = "Choose a Side!";
            // 
            // XButton
            // 
            this.XButton.Image = ((System.Drawing.Image)(resources.GetObject("XButton.Image")));
            this.XButton.Location = new System.Drawing.Point(12, 59);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(100, 100);
            this.XButton.TabIndex = 1;
            this.XButton.UseVisualStyleBackColor = true;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // OButton
            // 
            this.OButton.Image = ((System.Drawing.Image)(resources.GetObject("OButton.Image")));
            this.OButton.Location = new System.Drawing.Point(310, 59);
            this.OButton.Name = "OButton";
            this.OButton.Size = new System.Drawing.Size(100, 100);
            this.OButton.TabIndex = 2;
            this.OButton.UseVisualStyleBackColor = true;
            this.OButton.Click += new System.EventHandler(this.OButton_Click);
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(424, 215);
            this.Controls.Add(this.OButton);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.OrLabel);
            this.Name = "IntroScreen";
            this.Text = "Tic-Tac-Toe!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button OButton;
    }
}

