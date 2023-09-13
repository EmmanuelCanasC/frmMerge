namespace frmMerge
{
    partial class Form1
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
            InputTextBox = new TextBox();
            OutputTextBox = new TextBox();
            MergeSortButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(359, 166);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(100, 23);
            InputTextBox.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(359, 222);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(100, 23);
            OutputTextBox.TabIndex = 1;
            // 
            // MergeSortButton
            // 
            MergeSortButton.Location = new Point(359, 279);
            MergeSortButton.Name = "MergeSortButton";
            MergeSortButton.Size = new Size(75, 23);
            MergeSortButton.TabIndex = 2;
            MergeSortButton.Text = "Merge";
            MergeSortButton.UseVisualStyleBackColor = true;
            MergeSortButton.Click += MergeSortButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 166);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 225);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Salida Ordenada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 105);
            label3.Name = "label3";
            label3.Size = new Size(228, 15);
            label3.TabIndex = 5;
            label3.Text = "Ingrese los numeros separados por comas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MergeSortButton);
            Controls.Add(OutputTextBox);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private TextBox OutputTextBox;
        private Button MergeSortButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}