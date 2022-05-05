
namespace Kursach
{
    partial class OrderIngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderIngr));
            this.backButton = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.Order_button = new System.Windows.Forms.Button();
            this.ingrName = new System.Windows.Forms.ComboBox();
            this.NameIngr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 38;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Order_button
            // 
            this.Order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Order_button.Location = new System.Drawing.Point(336, 243);
            this.Order_button.Name = "Order_button";
            this.Order_button.Size = new System.Drawing.Size(100, 30);
            this.Order_button.TabIndex = 44;
            this.Order_button.Text = "Заказать";
            this.Order_button.UseVisualStyleBackColor = true;
            this.Order_button.Click += new System.EventHandler(this.Order_button_Click);
            // 
            // ingrName
            // 
            this.ingrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ingrName.FormattingEnabled = true;
            this.ingrName.Location = new System.Drawing.Point(402, 175);
            this.ingrName.Name = "ingrName";
            this.ingrName.Size = new System.Drawing.Size(266, 26);
            this.ingrName.TabIndex = 43;
            this.ingrName.SelectedIndexChanged += new System.EventHandler(this.ingrName_SelectedIndexChanged);
            // 
            // NameIngr
            // 
            this.NameIngr.AutoSize = true;
            this.NameIngr.BackColor = System.Drawing.Color.Transparent;
            this.NameIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameIngr.Location = new System.Drawing.Point(156, 178);
            this.NameIngr.Name = "NameIngr";
            this.NameIngr.Size = new System.Drawing.Size(201, 18);
            this.NameIngr.TabIndex = 42;
            this.NameIngr.Text = "Наименование ингредиента";
            // 
            // OrderIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order_button);
            this.Controls.Add(this.ingrName);
            this.Controls.Add(this.NameIngr);
            this.Controls.Add(this.backButton);
            this.Name = "OrderIngr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderIngr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button Order_button;
        private System.Windows.Forms.ComboBox ingrName;
        private System.Windows.Forms.Label NameIngr;
    }
}