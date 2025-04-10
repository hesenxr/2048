namespace WinFormsApp2
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Label subtitleLabel;
        private Button normalGameButton;
        private Button customizableGameButton;
        private Button exitButton;
        private Label instructionsLabel;
        private Panel backgroundPanel;

        // Disposes resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initializes UI components
        private void InitializeComponent()
        {
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.normalGameButton = new System.Windows.Forms.Button();
            this.customizableGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.backgroundPanel.Controls.Add(this.titleLabel);
            this.backgroundPanel.Controls.Add(this.subtitleLabel);
            this.backgroundPanel.Controls.Add(this.normalGameButton);
            this.backgroundPanel.Controls.Add(this.customizableGameButton);
            this.backgroundPanel.Controls.Add(this.exitButton);
            this.backgroundPanel.Controls.Add(this.instructionsLabel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(800, 450);
            this.backgroundPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(200, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(400, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "2048 Game";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.subtitleLabel.Location = new System.Drawing.Point(200, 80);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(400, 30);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "The Ultimate Puzzle Challenge";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalGameButton
            // 
            this.normalGameButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.normalGameButton.ForeColor = System.Drawing.Color.White;
            this.normalGameButton.Location = new System.Drawing.Point(300, 150);
            this.normalGameButton.Name = "normalGameButton";
            this.normalGameButton.Size = new System.Drawing.Size(200, 40);
            this.normalGameButton.TabIndex = 2;
            this.normalGameButton.Text = "Normal Game";
            this.normalGameButton.UseVisualStyleBackColor = false;
            this.normalGameButton.Click += new System.EventHandler(this.normalGameButton_Click);
            // 
            // customizableGameButton
            // 
            this.customizableGameButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.customizableGameButton.ForeColor = System.Drawing.Color.White;
            this.customizableGameButton.Location = new System.Drawing.Point(300, 200);
            this.customizableGameButton.Name = "customizableGameButton";
            this.customizableGameButton.Size = new System.Drawing.Size(200, 40);
            this.customizableGameButton.TabIndex = 3;
            this.customizableGameButton.Text = "Customizable Game";
            this.customizableGameButton.UseVisualStyleBackColor = false;
            this.customizableGameButton.Click += new System.EventHandler(this.customizableGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(300, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.instructionsLabel.Location = new System.Drawing.Point(100, 320);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(600, 60);
            this.instructionsLabel.TabIndex = 6;
            this.instructionsLabel.Text = "Use arrow keys to move tiles. Combine them to reach 2048!";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "WelcomeForm";
            this.Text = "Welcome to 2048 Game";
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
