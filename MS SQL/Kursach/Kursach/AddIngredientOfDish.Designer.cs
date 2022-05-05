
namespace Kursach
{
    partial class AddIngredientOfDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredientOfDish));
            this.ComBox1 = new System.Windows.Forms.ComboBox();
            this.dishName = new System.Windows.Forms.Label();
            this.ingrName = new System.Windows.Forms.Label();
            this.ComBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowMenu = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.dgMenu = new System.Windows.Forms.DataGrid();
            this.dgIngr = new System.Windows.Forms.DataGrid();
            this.ShowIng = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.ComBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngr)).BeginInit();
            this.SuspendLayout();
            // 
            // ComBox1
            // 
            this.ComBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ComBox1.FormattingEnabled = true;
            this.ComBox1.Location = new System.Drawing.Point(240, 24);
            this.ComBox1.Name = "ComBox1";
            this.ComBox1.Size = new System.Drawing.Size(266, 26);
            this.ComBox1.TabIndex = 34;
            // 
            // dishName
            // 
            this.dishName.AutoSize = true;
            this.dishName.BackColor = System.Drawing.Color.Transparent;
            this.dishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dishName.Location = new System.Drawing.Point(39, 26);
            this.dishName.Name = "dishName";
            this.dishName.Size = new System.Drawing.Size(161, 18);
            this.dishName.TabIndex = 33;
            this.dishName.Text = "Наименование блюда";
            // 
            // ingrName
            // 
            this.ingrName.AutoSize = true;
            this.ingrName.BackColor = System.Drawing.Color.Transparent;
            this.ingrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ingrName.Location = new System.Drawing.Point(39, 79);
            this.ingrName.Name = "ingrName";
            this.ingrName.Size = new System.Drawing.Size(165, 18);
            this.ingrName.TabIndex = 33;
            this.ingrName.Text = "Название ингредиента";
            // 
            // ComBox2
            // 
            this.ComBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ComBox2.FormattingEnabled = true;
            this.ComBox2.Location = new System.Drawing.Point(240, 80);
            this.ComBox2.Name = "ComBox2";
            this.ComBox2.Size = new System.Drawing.Size(266, 26);
            this.ComBox2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(39, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Количество";
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShowMenu.Location = new System.Drawing.Point(284, 183);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(100, 45);
            this.ShowMenu.TabIndex = 35;
            this.ShowMenu.Text = "Показать меню";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(661, 27);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 47);
            this.add_button.TabIndex = 36;
            this.add_button.Text = "Добавить ингредиент";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(661, 165);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 37;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgMenu
            // 
            this.dgMenu.DataMember = "";
            this.dgMenu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMenu.Location = new System.Drawing.Point(-1, 249);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(401, 201);
            this.dgMenu.TabIndex = 38;
            // 
            // dgIngr
            // 
            this.dgIngr.DataMember = "";
            this.dgIngr.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgIngr.Location = new System.Drawing.Point(397, 249);
            this.dgIngr.Name = "dgIngr";
            this.dgIngr.Size = new System.Drawing.Size(405, 201);
            this.dgIngr.TabIndex = 38;
            // 
            // ShowIng
            // 
            this.ShowIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShowIng.Location = new System.Drawing.Point(416, 183);
            this.ShowIng.Name = "ShowIng";
            this.ShowIng.Size = new System.Drawing.Size(100, 45);
            this.ShowIng.TabIndex = 35;
            this.ShowIng.Text = "Показать ингредиенты";
            this.ShowIng.UseVisualStyleBackColor = true;
            this.ShowIng.Click += new System.EventHandler(this.ShowIng_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delete_button.Location = new System.Drawing.Point(661, 96);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 47);
            this.delete_button.TabIndex = 36;
            this.delete_button.Text = "Удалить ингредиент";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // ComBox3
            // 
            this.ComBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ComBox3.FormattingEnabled = true;
            this.ComBox3.Location = new System.Drawing.Point(240, 128);
            this.ComBox3.Name = "ComBox3";
            this.ComBox3.Size = new System.Drawing.Size(121, 26);
            this.ComBox3.TabIndex = 39;
            // 
            // AddIngredientOfDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComBox3);
            this.Controls.Add(this.dgIngr);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.ShowIng);
            this.Controls.Add(this.ShowMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComBox2);
            this.Controls.Add(this.ingrName);
            this.Controls.Add(this.ComBox1);
            this.Controls.Add(this.dishName);
            this.Name = "AddIngredientOfDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIngredientOfDish";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBox1;
        private System.Windows.Forms.Label dishName;
        private System.Windows.Forms.Label ingrName;
        private System.Windows.Forms.ComboBox ComBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button backButton;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.DataGrid dgMenu;
        private System.Windows.Forms.DataGrid dgIngr;
        private System.Windows.Forms.Button ShowIng;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ComboBox ComBox3;
    }
}