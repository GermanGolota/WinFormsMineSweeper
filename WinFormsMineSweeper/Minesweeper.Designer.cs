
namespace WinFormsMineSweeper
{
    partial class Minesweeper
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
            this.StartButton = new System.Windows.Forms.Button();
            this.MinesLabel = new System.Windows.Forms.Label();
            this.DifficultyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(492, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 100);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MinesLabel
            // 
            this.MinesLabel.AutoSize = true;
            this.MinesLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinesLabel.Location = new System.Drawing.Point(170, 20);
            this.MinesLabel.Name = "MinesLabel";
            this.MinesLabel.Size = new System.Drawing.Size(0, 86);
            this.MinesLabel.TabIndex = 1;
            // 
            // DifficultyButton
            // 
            this.DifficultyButton.Location = new System.Drawing.Point(778, 12);
            this.DifficultyButton.Name = "DifficultyButton";
            this.DifficultyButton.Size = new System.Drawing.Size(159, 100);
            this.DifficultyButton.TabIndex = 2;
            this.DifficultyButton.Text = "To difficulty selection";
            this.DifficultyButton.UseVisualStyleBackColor = true;
            this.DifficultyButton.Click += new System.EventHandler(this.DifficultyButton_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 568);
            this.Controls.Add(this.DifficultyButton);
            this.Controls.Add(this.MinesLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "Minesweeper";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label MinesLabel;
        private System.Windows.Forms.Button DifficultyButton;
    }
}

