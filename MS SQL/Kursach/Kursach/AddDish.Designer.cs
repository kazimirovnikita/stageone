
namespace Kursach
{
    partial class AddDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDish));
            this.backButton = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.CostPrice = new System.Windows.Forms.TextBox();
            this.NameDish = new System.Windows.Forms.TextBox();
            this.PR = new System.Windows.Forms.Label();
            this.CostPr = new System.Windows.Forms.Label();
            this.dichName = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.ShowMenu = new System.Windows.Forms.Button();
            this.dgMenu = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(644, 154);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(644, 29);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 30);
            this.add_button.TabIndex = 26;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Price.Location = new System.Drawing.Point(207, 109);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(91, 24);
            this.Price.TabIndex = 23;
            // 
            // CostPrice
            // 
            this.CostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CostPrice.Location = new System.Drawing.Point(207, 66);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(91, 24);
            this.CostPrice.TabIndex = 24;
            // 
            // NameDish
            // 
            this.NameDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDish.Location = new System.Drawing.Point(207, 26);
            this.NameDish.Name = "NameDish";
            this.NameDish.Size = new System.Drawing.Size(167, 24);
            this.NameDish.TabIndex = 25;
            // 
            // PR
            // 
            this.PR.AutoSize = true;
            this.PR.BackColor = System.Drawing.Color.Transparent;
            this.PR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PR.Location = new System.Drawing.Point(19, 112);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(43, 18);
            this.PR.TabIndex = 19;
            this.PR.Text = "Цена";
            // 
            // CostPr
            // 
            this.CostPr.AutoSize = true;
            this.CostPr.BackColor = System.Drawing.Color.Transparent;
            this.CostPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CostPr.Location = new System.Drawing.Point(19, 69);
            this.CostPr.Name = "CostPr";
            this.CostPr.Size = new System.Drawing.Size(119, 18);
            this.CostPr.TabIndex = 20;
            this.CostPr.Text = "Себестоимость";
            // 
            // dichName
            // 
            this.dichName.AutoSize = true;
            this.dichName.BackColor = System.Drawing.Color.Transparent;
            this.dichName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dichName.Location = new System.Drawing.Point(19, 29);
            this.dichName.Name = "dichName";
            this.dichName.Size = new System.Drawing.Size(161, 18);
            this.dichName.TabIndex = 21;
            this.dichName.Text = "Наименование блюда";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.BackColor = System.Drawing.Color.Transparent;
            this.Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Desc.Location = new System.Drawing.Point(19, 154);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(126, 18);
            this.Desc.TabIndex = 19;
            this.Desc.Text = "Описание блюда";
            this.Desc.Click += new System.EventHandler(this.PR_Click);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Description.Location = new System.Drawing.Point(207, 151);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(348, 24);
            this.Description.TabIndex = 23;
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShowMenu.Location = new System.Drawing.Point(644, 85);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(100, 45);
            this.ShowMenu.TabIndex = 27;
            this.ShowMenu.Text = "Показать меню";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // dgMenu
            // 
            this.dgMenu.DataMember = "";
            this.dgMenu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMenu.Location = new System.Drawing.Point(1, 213);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(798, 235);
            this.dgMenu.TabIndex = 28;
            // 
            // AddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.ShowMenu);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CostPrice);
            this.Controls.Add(this.NameDish);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.PR);
            this.Controls.Add(this.CostPr);
            this.Controls.Add(this.dichName);
            this.Name = "AddDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDish";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox CostPrice;
        private System.Windows.Forms.TextBox NameDish;
        private System.Windows.Forms.Label PR;
        private System.Windows.Forms.Label CostPr;
        private System.Windows.Forms.Label dichName;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.TextBox Description;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.DataGrid dgMenu;
    }
}