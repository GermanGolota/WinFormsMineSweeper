
namespace WinFormsMineSweeper
{
    partial class CustomDifficultySelectorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthField = new System.Windows.Forms.TextBox();
            this.HeightField = new System.Windows.Forms.TextBox();
            this.MinesField = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mines";
            // 
            // WidthField
            // 
            this.WidthField.Location = new System.Drawing.Point(100, 50);
            this.WidthField.Name = "WidthField";
            this.WidthField.Size = new System.Drawing.Size(80, 23);
            this.WidthField.TabIndex = 3;
            // 
            // HeightField
            // 
            this.HeightField.Location = new System.Drawing.Point(100, 117);
            this.HeightField.Name = "HeightField";
            this.HeightField.Size = new System.Drawing.Size(80, 23);
            this.HeightField.TabIndex = 4;
            // 
            // MinesField
            // 
            this.MinesField.Location = new System.Drawing.Point(100, 180);
            this.MinesField.Name = "MinesField";
            this.MinesField.Size = new System.Drawing.Size(80, 23);
            this.MinesField.TabIndex = 5;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(80, 223);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(121, 46);
            this.SelectButton.TabIndex = 6;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // CustomDifficultySelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 306);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.MinesField);
            this.Controls.Add(this.HeightField);
            this.Controls.Add(this.WidthField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomDifficultySelectorForm";
            this.Text = "CustomDifficultySelectorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthField;
        private System.Windows.Forms.TextBox HeightField;
        private System.Windows.Forms.TextBox MinesField;
        private System.Windows.Forms.Button SelectButton;
    }
}