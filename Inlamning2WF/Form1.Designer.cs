﻿namespace Inlamning2WF
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(427, 36);
            label1.TabIndex = 0;
            label1.Text = "Hej och välkommen till portalen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 134);
            label2.Name = "label2";
            label2.Size = new Size(232, 23);
            label2.TabIndex = 1;
            label2.Text = "Om du är Admin tryck här =>";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 204);
            label3.Name = "label3";
            label3.Size = new Size(232, 23);
            label3.TabIndex = 2;
            label3.Text = "Om du är Säljare tryck här =>";
            // 
            // button3
            // 
            button3.Location = new Point(41, 277);
            button3.Name = "button3";
            button3.Size = new Size(133, 29);
            button3.TabIndex = 5;
            button3.Text = "Avsluta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(322, 134);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 6;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 198);
            button2.Name = "button2";
            button2.Size = new Size(133, 29);
            button2.TabIndex = 7;
            button2.Text = "Säljare";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 334);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(818, 381);
            MinimumSize = new Size(818, 381);
            Name = "Form1";
            Text = "Välkomment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}