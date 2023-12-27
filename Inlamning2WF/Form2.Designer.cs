namespace Inlamning2WF
{
    partial class Form2
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(144, 50);
            button1.Name = "button1";
            button1.Size = new Size(135, 41);
            button1.TabIndex = 0;
            button1.Text = "Till portal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 1;
            label1.Text = "Hej och välkommen Admin";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 76);
            label2.MinimumSize = new Size(123, 23);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 2;
            label2.Text = "Lägg till säljare";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 118);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Säljares namn : ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 187);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 4;
            label4.Text = "Person nummer : ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(43, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(43, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(39, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(144, 3);
            button2.Name = "button2";
            button2.Size = new Size(135, 41);
            button2.TabIndex = 9;
            button2.Text = "Lägg till";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(340, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(623, 372);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 50);
            button3.Name = "button3";
            button3.Size = new Size(135, 41);
            button3.TabIndex = 11;
            button3.Text = "Avsluta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(340, 55);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Resultatet :";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Location = new Point(43, 320);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(282, 94);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(43, 254);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 14;
            label7.Text = "Distrikt : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 423);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 27);
            textBox4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 427);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 16;
            label5.Text = "resultatet :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(975, 462);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Admin";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button button3;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private TextBox textBox4;
        private Label label5;
    }
}