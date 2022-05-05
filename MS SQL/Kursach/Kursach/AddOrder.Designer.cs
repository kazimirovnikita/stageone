
namespace Kursach
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.dishName = new System.Windows.Forms.ComboBox();
            this.NameDish = new System.Windows.Forms.Label();
            this.NameEmpl = new System.Windows.Forms.ComboBox();
            this.Empl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ShowMenu = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dishName
            // 
            this.dishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dishName.FormattingEnabled = true;
            this.dishName.Location = new System.Drawing.Point(366, 254);
            this.dishName.Name = "dishName";
            this.dishName.Size = new System.Drawing.Size(266, 26);
            this.dishName.TabIndex = 36;
            this.dishName.SelectedIndexChanged += new System.EventHandler(this.dishName_SelectedIndexChanged);
            // 
            // NameDish
            // 
            this.NameDish.AutoSize = true;
            this.NameDish.BackColor = System.Drawing.Color.Transparent;
            this.NameDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameDish.Location = new System.Drawing.Point(147, 254);
            this.NameDish.Name = "NameDish";
            this.NameDish.Size = new System.Drawing.Size(161, 18);
            this.NameDish.TabIndex = 35;
            this.NameDish.Text = "Наименование блюда";
            // 
            // NameEmpl
            // 
            this.NameEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameEmpl.FormattingEnabled = true;
            this.NameEmpl.Location = new System.Drawing.Point(428, 94);
            this.NameEmpl.Name = "NameEmpl";
            this.NameEmpl.Size = new System.Drawing.Size(95, 26);
            this.NameEmpl.TabIndex = 36;
            // 
            // Empl
            // 
            this.Empl.AutoSize = true;
            this.Empl.BackColor = System.Drawing.Color.Transparent;
            this.Empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Empl.Location = new System.Drawing.Point(227, 97);
            this.Empl.Name = "Empl";
            this.Empl.Size = new System.Drawing.Size(130, 18);
            this.Empl.TabIndex = 35;
            this.Empl.Text = "Выбирите повара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(227, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Номер стола";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Number.FormattingEnabled = true;
            this.Number.Location = new System.Drawing.Point(428, 139);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(95, 26);
            this.Number.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(216, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(195, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Для начала выберите повара и номер стола";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(264, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Выберите желаемые блюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(171, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ваш номер заказа";
            // 
            // NumberOrder
            // 
            this.NumberOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NumberOrder.Location = new System.Drawing.Point(366, 399);
            this.NumberOrder.Name = "NumberOrder";
            this.NumberOrder.Size = new System.Drawing.Size(63, 24);
            this.NumberOrder.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(562, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(675, 280);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 30);
            this.add_button.TabIndex = 38;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 38;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(675, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.TabIndex = 38;
            this.button3.Text = "Показать поваров";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShowMenu.Location = new System.Drawing.Point(675, 332);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(100, 45);
            this.ShowMenu.TabIndex = 39;
            this.ShowMenu.Text = "Показать меню";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click_1);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Quantity.FormattingEnabled = true;
            this.Quantity.Location = new System.Drawing.Point(366, 301);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(63, 26);
            this.Quantity.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(265, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Цена";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.priceBox.Location = new System.Drawing.Point(366, 353);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(63, 24);
            this.priceBox.TabIndex = 37;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ShowMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.NumberOrder);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.NameEmpl);
            this.Controls.Add(this.dishName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Empl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDish);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dishName;
        private System.Windows.Forms.Label NameDish;
        private System.Windows.Forms.ComboBox NameEmpl;
        private System.Windows.Forms.Label Empl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_button;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.ComboBox Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceBox;
    }
}