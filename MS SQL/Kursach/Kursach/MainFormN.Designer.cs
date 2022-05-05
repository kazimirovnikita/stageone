
namespace Kursach
{
    partial class MainFormN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormN));
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.SignIn = new System.Windows.Forms.Button();
            this.Login_lab = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.regist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Личный кабинет";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(395, 253);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(114, 20);
            this.Password.TabIndex = 15;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.BackColor = System.Drawing.Color.Transparent;
            this.Пароль.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.Location = new System.Drawing.Point(278, 253);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(67, 20);
            this.Пароль.TabIndex = 13;
            this.Пароль.Text = "Пароль";
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignIn.Location = new System.Drawing.Point(350, 299);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(100, 33);
            this.SignIn.TabIndex = 17;
            this.SignIn.Text = "Вход";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Login_lab
            // 
            this.Login_lab.AutoSize = true;
            this.Login_lab.BackColor = System.Drawing.Color.Transparent;
            this.Login_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_lab.Location = new System.Drawing.Point(278, 212);
            this.Login_lab.Name = "Login_lab";
            this.Login_lab.Size = new System.Drawing.Size(55, 20);
            this.Login_lab.TabIndex = 12;
            this.Login_lab.Text = "Логин";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(395, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(114, 20);
            this.Login.TabIndex = 14;
            // 
            // regist
            // 
            this.regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regist.Location = new System.Drawing.Point(311, 347);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(179, 32);
            this.regist.TabIndex = 17;
            this.regist.Text = "Зарегистрироваться";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.regist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(328, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Санкт-Петербург";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(268, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ресторан \"Облака\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(272, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Телефон для связи: +79141560516";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(261, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Режим работы: ПН-ВС с 10:00 до 23:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Login_lab);
            this.Controls.Add(this.Пароль);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Пароль;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label Login_lab;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}