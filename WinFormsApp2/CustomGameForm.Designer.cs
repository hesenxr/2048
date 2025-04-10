namespace WinFormsApp2
{
    partial class CustomGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label boardSizeLabel;
        private Label targetValueLabel;
        private TextBox boardSizeTextBox;
        private TextBox targetValueTextBox;
        private Button startCustomGameButton;

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
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.targetValueLabel = new System.Windows.Forms.Label();
            this.boardSizeTextBox = new System.Windows.Forms.TextBox();
            this.targetValueTextBox = new System.Windows.Forms.TextBox();
            this.startCustomGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(100, 100);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(79, 17);
            this.boardSizeLabel.TabIndex = 0;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // targetValueLabel
            // 
            this.targetValueLabel.AutoSize = true;
            this.targetValueLabel.Location = new System.Drawing.Point(100, 150);
            this.targetValueLabel.Name = "targetValueLabel";
            this.targetValueLabel.Size = new System.Drawing.Size(90, 17);
            this.targetValueLabel.TabIndex = 1;
            this.targetValueLabel.Text = "Target Value:";
            // 
            // boardSizeTextBox
            // 
            this.boardSizeTextBox.Location = new System.Drawing.Point(200, 100);
            this.boardSizeTextBox.Name = "boardSizeTextBox";
            this.boardSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.boardSizeTextBox.TabIndex = 2;
            // 
            // targetValueTextBox
            // 
            this.targetValueTextBox.Location = new System.Drawing.Point(200, 150);
            this.targetValueTextBox.Name = "targetValueTextBox";
            this.targetValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.targetValueTextBox.TabIndex = 3;
            // 
            // startCustomGameButton
            // 
            this.startCustomGameButton.Location = new System.Drawing.Point(200, 200);
            this.startCustomGameButton.Name = "startCustomGameButton";
            this.startCustomGameButton.Size = new System.Drawing.Size(100, 30);
            this.startCustomGameButton.TabIndex = 4;
            this.startCustomGameButton.Text = "Start Game";
            this.startCustomGameButton.UseVisualStyleBackColor = true;
            this.startCustomGameButton.Click += new System.EventHandler(this.startCustomGameButton_Click);
            // 
            // CustomGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.startCustomGameButton);
            this.Controls.Add(this.targetValueTextBox);
            this.Controls.Add(this.boardSizeTextBox);
            this.Controls.Add(this.targetValueLabel);
            this.Controls.Add(this.boardSizeLabel);
            this.Name = "CustomGameForm";
            this.Text = "Custom Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
