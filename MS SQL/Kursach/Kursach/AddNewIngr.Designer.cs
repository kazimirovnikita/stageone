
namespace Kursach
{
    partial class AddNewIngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewIngr));
            this.Units = new System.Windows.Forms.TextBox();
            this.CostPrice = new System.Windows.Forms.TextBox();
            this.NameIngr = new System.Windows.Forms.TextBox();
            this.PR = new System.Windows.Forms.Label();
            this.CostPr = new System.Windows.Forms.Label();
            this.dichName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Qunt = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // Units
            // 
            this.Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Units.Location = new System.Drawing.Point(402, 261);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(91, 24);
            this.Units.TabIndex = 29;
            this.Units.TextChanged += new System.EventHandler(this.Units_TextChanged);
            // 
            // CostPrice
            // 
            this.CostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CostPrice.Location = new System.Drawing.Point(402, 212);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(91, 24);
            this.CostPrice.TabIndex = 30;
            // 
            // NameIngr
            // 
            this.NameIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameIngr.Location = new System.Drawing.Point(402, 111);
            this.NameIngr.Name = "NameIngr";
            this.NameIngr.Size = new System.Drawing.Size(167, 24);
            this.NameIngr.TabIndex = 31;
            // 
            // PR
            // 
            this.PR.AutoSize = true;
            this.PR.BackColor = System.Drawing.Color.Transparent;
            this.PR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PR.Location = new System.Drawing.Point(243, 264);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(110, 18);
            this.PR.TabIndex = 26;
            this.PR.Text = "Ед. измерения";
            // 
            // CostPr
            // 
            this.CostPr.AutoSize = true;
            this.CostPr.BackColor = System.Drawing.Color.Transparent;
            this.CostPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CostPr.Location = new System.Drawing.Point(234, 215);
            this.CostPr.Name = "CostPr";
            this.CostPr.Size = new System.Drawing.Size(119, 18);
            this.CostPr.TabIndex = 27;
            this.CostPr.Text = "Себестоимость";
            // 
            // dichName
            // 
            this.dichName.AutoSize = true;
            this.dichName.BackColor = System.Drawing.Color.Transparent;
            this.dichName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dichName.Location = new System.Drawing.Point(152, 114);
            this.dichName.Name = "dichName";
            this.dichName.Size = new System.Drawing.Size(201, 18);
            this.dichName.TabIndex = 28;
            this.dichName.Text = "Наименование ингредиента";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 47;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Qunt
            // 
            this.Qunt.AutoSize = true;
            this.Qunt.BackColor = System.Drawing.Color.Transparent;
            this.Qunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Qunt.Location = new System.Drawing.Point(261, 168);
            this.Qunt.Name = "Qunt";
            this.Qunt.Size = new System.Drawing.Size(92, 18);
            this.Qunt.TabIndex = 27;
            this.Qunt.Text = "Количество";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Quantity.Location = new System.Drawing.Point(402, 162);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(91, 24);
            this.Quantity.TabIndex = 30;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(334, 333);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 30);
            this.add_button.TabIndex = 48;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddNewIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.CostPrice);
            this.Controls.Add(this.NameIngr);
            this.Controls.Add(this.PR);
            this.Controls.Add(this.Qunt);
            this.Controls.Add(this.CostPr);
            this.Controls.Add(this.dichName);
            this.Name = "AddNewIngr";
            this.Text = "AddNewIngr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Units;
        private System.Windows.Forms.TextBox CostPrice;
        private System.Windows.Forms.TextBox NameIngr;
        private System.Windows.Forms.Label PR;
        private System.Windows.Forms.Label CostPr;
        private System.Windows.Forms.Label dichName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Qunt;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button add_button;
        private System.Data.OleDb.OleDbConnection cn;
    }
}