namespace WinFormsAppAlgoritmo
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(44, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 357);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 120);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 0;
            label1.Text = "Numero da conta";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.Location = new Point(87, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "123456";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 120);
            label2.Name = "label2";
            label2.Size = new Size(160, 24);
            label2.TabIndex = 2;
            label2.Text = "Titular da conta";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 31);
            textBox2.TabIndex = 3;
            textBox2.Text = "Christian padilha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 209);
            label3.Name = "label3";
            label3.Size = new Size(139, 24);
            label3.TabIndex = 4;
            label3.Text = "Tipo da conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 209);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 5;
            label4.Text = "Saldo da conta";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.PaleGreen;
            textBox3.Location = new Point(87, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 31);
            textBox3.TabIndex = 6;
            textBox3.Text = "1500";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(409, 245);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 31);
            textBox4.TabIndex = 7;
            textBox4.Text = "Corrente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
    }
}
