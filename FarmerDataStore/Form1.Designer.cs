namespace FarmerDataStore
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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(822, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 43);
            textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(822, 271);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(450, 43);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(861, 550);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(822, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 43);
            textBox2.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker2.Location = new Point(822, 335);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(450, 43);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.Value = new DateTime(2024, 12, 2, 16, 54, 0, 0);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(822, 414);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(450, 43);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(822, 481);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 43);
            textBox4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 139);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 3;
            label1.Text = "RMCID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 204);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 3;
            label2.Text = "Farmerid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 271);
            label3.Name = "label3";
            label3.Size = new Size(73, 37);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 340);
            label4.Name = "label4";
            label4.Size = new Size(76, 37);
            label4.TabIndex = 3;
            label4.Text = "TIME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 417);
            label5.Name = "label5";
            label5.Size = new Size(110, 37);
            label5.TabIndex = 3;
            label5.Text = "kiosk ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(567, 487);
            label6.Name = "label6";
            label6.Size = new Size(98, 37);
            label6.TabIndex = 3;
            label6.Text = "weight";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 856);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
