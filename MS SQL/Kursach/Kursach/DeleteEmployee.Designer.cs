
namespace Kursach
{
    partial class DeleteEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployee));
            this.Surname = new System.Windows.Forms.TextBox();
            this.NameEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.dgEmp = new System.Windows.Forms.DataGrid();
            this.Show_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Surname.Location = new System.Drawing.Point(176, 204);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(182, 24);
            this.Surname.TabIndex = 22;
            // 
            // NameEmp
            // 
            this.NameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEmp.Location = new System.Drawing.Point(176, 164);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(116, 24);
            this.NameEmp.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(29, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(29, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Имя";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 30);
            this.back_button.TabIndex = 25;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id Сотрудника";
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delete_button.Location = new System.Drawing.Point(32, 272);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 30);
            this.delete_button.TabIndex = 26;
            this.delete_button.Text = "Уволить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // dgEmp
            // 
            this.dgEmp.DataMember = "";
            this.dgEmp.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgEmp.Location = new System.Drawing.Point(383, 1);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.Size = new System.Drawing.Size(417, 449);
            this.dgEmp.TabIndex = 27;
            // 
            // Show_button
            // 
            this.Show_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Show_button.Location = new System.Drawing.Point(176, 262);
            this.Show_button.Name = "Show_button";
            this.Show_button.Size = new System.Drawing.Size(182, 50);
            this.Show_button.TabIndex = 28;
            this.Show_button.Text = "Показать всех сотрудников";
            this.Show_button.UseVisualStyleBackColor = true;
            this.Show_button.Click += new System.EventHandler(this.Show_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Show_button);
            this.Controls.Add(this.dgEmp);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "DeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox NameEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGrid dgEmp;
        private System.Windows.Forms.Button Show_button;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}