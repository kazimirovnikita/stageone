
namespace Kursach
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.Dolznost = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.tfnumber = new System.Windows.Forms.TextBox();
            this.ZP = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.NameEmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dolznost
            // 
            this.Dolznost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Dolznost.FormattingEnabled = true;
            this.Dolznost.Items.AddRange(new object[] {
            "Администратор",
            "Повар"});
            this.Dolznost.Location = new System.Drawing.Point(345, 155);
            this.Dolznost.Name = "Dolznost";
            this.Dolznost.Size = new System.Drawing.Size(182, 26);
            this.Dolznost.TabIndex = 18;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 30);
            this.back_button.TabIndex = 17;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(651, 204);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 30);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // tfnumber
            // 
            this.tfnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tfnumber.Location = new System.Drawing.Point(345, 248);
            this.tfnumber.Name = "tfnumber";
            this.tfnumber.Size = new System.Drawing.Size(116, 24);
            this.tfnumber.TabIndex = 12;
            // 
            // ZP
            // 
            this.ZP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ZP.Location = new System.Drawing.Point(345, 201);
            this.ZP.Name = "ZP";
            this.ZP.Size = new System.Drawing.Size(116, 24);
            this.ZP.TabIndex = 13;
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Surname.Location = new System.Drawing.Point(345, 114);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(182, 24);
            this.Surname.TabIndex = 14;
            // 
            // NameEmp
            // 
            this.NameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEmp.Location = new System.Drawing.Point(345, 74);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(116, 24);
            this.NameEmp.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(165, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата приема на работу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(165, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(165, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Зарплата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(165, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(165, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(165, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(345, 294);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 24);
            this.date.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(165, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Логин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(165, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(345, 339);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(116, 24);
            this.Login.TabIndex = 15;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Password.Location = new System.Drawing.Point(345, 379);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(116, 24);
            this.Password.TabIndex = 14;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Dolznost);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.tfnumber);
            this.Controls.Add(this.ZP);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Dolznost;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox tfnumber;
        private System.Windows.Forms.TextBox ZP;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox NameEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
    }
}