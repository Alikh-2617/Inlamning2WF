namespace Inlamning2WF
{
    partial class Form3
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPR = new TextBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(193, 413);
            button1.Name = "button1";
            button1.Size = new Size(128, 39);
            button1.TabIndex = 0;
            button1.Text = "till portalen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 1;
            label1.Text = "Hej och välkommen säljaren ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 60);
            label2.Name = "label2";
            label2.Size = new Size(378, 20);
            label2.TabIndex = 2;
            label2.Text = "skriv ditt person nummer för att kunna hitta dig :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 106);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 3;
            label3.Text = "Person nummer ";
            // 
            // tbPR
            // 
            tbPR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPR.Location = new Point(61, 129);
            tbPR.Name = "tbPR";
            tbPR.Size = new Size(312, 27);
            tbPR.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(405, 117);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(381, 170);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 240);
            label4.Name = "label4";
            label4.Size = new Size(228, 20);
            label4.TabIndex = 8;
            label4.Text = "Vill du lägga till nya sålda boker";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(61, 298);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 10;
            label6.Text = "Antal : ";
            // 
            // button2
            // 
            button2.Location = new Point(193, 364);
            button2.Name = "button2";
            button2.Size = new Size(128, 43);
            button2.TabIndex = 11;
            button2.Text = "Lägg till";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(65, 364);
            button3.Name = "button3";
            button3.Size = new Size(117, 43);
            button3.TabIndex = 12;
            button3.Text = "Avsluta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 318);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(279, 162);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Hitta mig";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(405, 321);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 15;
            label5.Text = "Resultat om uppdate : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 318);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(836, 464);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(tbPR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximumSize = new Size(854, 511);
            MinimumSize = new Size(854, 511);
            Name = "Form3";
            Text = "Säljare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbPR;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label6;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Label label5;
        private TextBox textBox1;
    }
}