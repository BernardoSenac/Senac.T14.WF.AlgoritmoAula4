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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(746, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de conta";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 29);
            textBox3.TabIndex = 8;
            textBox3.Text = "Corrente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 109);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 7;
            label3.Text = "Tipo da conta:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Lime;
            textBox4.Location = new Point(17, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 29);
            textBox4.TabIndex = 6;
            textBox4.Text = "R$5.000,00";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 109);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 5;
            label4.Text = "Saldo da conta:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(559, 42);
            button1.Name = "button1";
            button1.Size = new Size(148, 126);
            button1.TabIndex = 4;
            button1.Text = "enviar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 29);
            textBox2.TabIndex = 3;
            textBox2.Text = "Bernardo Augusto Soder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 27);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 2;
            label2.Text = "Titular da conta:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 255);
            textBox1.Location = new Point(17, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 29);
            textBox1.TabIndex = 1;
            textBox1.Text = "12415123";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "Número da conta:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 230);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
    }
}
