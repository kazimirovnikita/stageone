
namespace Kursach
{
    partial class DeleteIng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteIng));
            this.ingrName = new System.Windows.Forms.ComboBox();
            this.NameIngr = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // ingrName
            // 
            this.ingrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ingrName.FormattingEnabled = true;
            this.ingrName.Location = new System.Drawing.Point(385, 137);
            this.ingrName.Name = "ingrName";
            this.ingrName.Size = new System.Drawing.Size(266, 26);
            this.ingrName.TabIndex = 38;
            this.ingrName.SelectedIndexChanged += new System.EventHandler(this.ingrName_SelectedIndexChanged);
            // 
            // NameIngr
            // 
            this.NameIngr.AutoSize = true;
            this.NameIngr.BackColor = System.Drawing.Color.Transparent;
            this.NameIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameIngr.Location = new System.Drawing.Point(166, 137);
            this.NameIngr.Name = "NameIngr";
            this.NameIngr.Size = new System.Drawing.Size(201, 18);
            this.NameIngr.TabIndex = 37;
            this.NameIngr.Text = "Наименование ингредиента";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delete_button.Location = new System.Drawing.Point(350, 210);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 30);
            this.delete_button.TabIndex = 41;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // DeleteIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ingrName);
            this.Controls.Add(this.NameIngr);
            this.Name = "DeleteIng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteIng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ingrName;
        private System.Windows.Forms.Label NameIngr;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button delete_button;
        private System.Data.OleDb.OleDbConnection cn;
    }
}