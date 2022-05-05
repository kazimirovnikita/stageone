
namespace Kursach
{
    partial class NewDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDish));
            this.Quantity = new System.Windows.Forms.ComboBox();
            this.ShowMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.NumberOrder = new System.Windows.Forms.TextBox();
            this.dishName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameDish = new System.Windows.Forms.Label();
            this.dgMenu = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Quantity.FormattingEnabled = true;
            this.Quantity.Location = new System.Drawing.Point(343, 163);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(63, 26);
            this.Quantity.TabIndex = 49;
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShowMenu.Location = new System.Drawing.Point(652, 144);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(100, 45);
            this.ShowMenu.TabIndex = 48;
            this.ShowMenu.Text = "Показать меню";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(652, 75);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 30);
            this.add_button.TabIndex = 47;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // NumberOrder
            // 
            this.NumberOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NumberOrder.Location = new System.Drawing.Point(343, 75);
            this.NumberOrder.Name = "NumberOrder";
            this.NumberOrder.Size = new System.Drawing.Size(63, 24);
            this.NumberOrder.TabIndex = 45;
            // 
            // dishName
            // 
            this.dishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dishName.FormattingEnabled = true;
            this.dishName.Location = new System.Drawing.Point(343, 119);
            this.dishName.Name = "dishName";
            this.dishName.Size = new System.Drawing.Size(266, 26);
            this.dishName.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(148, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ваш номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(193, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Количество";
            // 
            // NameDish
            // 
            this.NameDish.AutoSize = true;
            this.NameDish.BackColor = System.Drawing.Color.Transparent;
            this.NameDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameDish.Location = new System.Drawing.Point(124, 119);
            this.NameDish.Name = "NameDish";
            this.NameDish.Size = new System.Drawing.Size(161, 18);
            this.NameDish.TabIndex = 43;
            this.NameDish.Text = "Наименование блюда";
            // 
            // dgMenu
            // 
            this.dgMenu.DataMember = "";
            this.dgMenu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMenu.Location = new System.Drawing.Point(12, 240);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(776, 210);
            this.dgMenu.TabIndex = 50;
            // 
            // NewDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ShowMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.NumberOrder);
            this.Controls.Add(this.dishName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDish);
            this.Name = "NewDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewDish";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Quantity;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox NumberOrder;
        private System.Windows.Forms.ComboBox dishName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameDish;
        private System.Windows.Forms.DataGrid dgMenu;
        private System.Data.OleDb.OleDbConnection cn;
    }
}