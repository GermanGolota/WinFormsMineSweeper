
namespace WinFormsMineSweeper
{
    partial class OptionsSelectionForm
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
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.CustomButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.MineLabel = new System.Windows.Forms.Label();
            this.PredeterminedDificultiesContainer = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PredeterminedDificultiesContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // EasyButton
            // 
            this.EasyButton.Location = new System.Drawing.Point(17, 17);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(150, 75);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.Tag = "Easy";
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            // 
            // MediumButton
            // 
            this.MediumButton.Location = new System.Drawing.Point(17, 98);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(150, 75);
            this.MediumButton.TabIndex = 1;
            this.MediumButton.Tag = "Medium";
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            // 
            // HardButton
            // 
            this.HardButton.Location = new System.Drawing.Point(17, 179);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(150, 75);
            this.HardButton.TabIndex = 2;
            this.HardButton.Tag = "Hard";
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            // 
            // CustomButton
            // 
            this.CustomButton.Location = new System.Drawing.Point(125, 260);
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.Size = new System.Drawing.Size(150, 75);
            this.CustomButton.TabIndex = 3;
            this.CustomButton.Text = "Custom";
            this.CustomButton.UseVisualStyleBackColor = true;
            this.CustomButton.Click += new System.EventHandler(this.CustomButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(12, 19);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(52, 15);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Size:N/A";
            // 
            // MineLabel
            // 
            this.MineLabel.AutoSize = true;
            this.MineLabel.Location = new System.Drawing.Point(12, 49);
            this.MineLabel.Name = "MineLabel";
            this.MineLabel.Size = new System.Drawing.Size(64, 15);
            this.MineLabel.TabIndex = 5;
            this.MineLabel.Text = "Mines:N/A";
            // 
            // PredeterminedDificultiesContainer
            // 
            this.PredeterminedDificultiesContainer.Controls.Add(this.HardButton);
            this.PredeterminedDificultiesContainer.Controls.Add(this.MediumButton);
            this.PredeterminedDificultiesContainer.Controls.Add(this.EasyButton);
            this.PredeterminedDificultiesContainer.Location = new System.Drawing.Point(108, 0);
            this.PredeterminedDificultiesContainer.Name = "PredeterminedDificultiesContainer";
            this.PredeterminedDificultiesContainer.Size = new System.Drawing.Size(190, 261);
            this.PredeterminedDificultiesContainer.TabIndex = 6;
            this.PredeterminedDificultiesContainer.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(297, 277);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 58);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OptionsSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PredeterminedDificultiesContainer);
            this.Controls.Add(this.MineLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.CustomButton);
            this.Name = "OptionsSelectionForm";
            this.Text = "OptionsSelection";
            this.PredeterminedDificultiesContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button CustomButton;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label MineLabel;
        private System.Windows.Forms.GroupBox PredeterminedDificultiesContainer;
        private System.Windows.Forms.Button StartButton;
    }
}