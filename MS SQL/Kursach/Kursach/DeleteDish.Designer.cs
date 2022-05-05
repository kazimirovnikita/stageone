
namespace Kursach
{
    partial class DeleteDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDish));
            this.dgMenu = new System.Windows.Forms.DataGrid();
            this.ShowMenu = new System.Windows.Forms.Button();
            this.dichName = new System.Windows.Forms.Label();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMenu
            // 
            this.dgMenu.DataMember = "";
            this.dgMenu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMenu.Location = new System.Drawing.Point(1, 215);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(798, 236);
            this.dgMenu.TabIndex = 30;
            // 
            // ShowMenu
            // 
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShowMenu.Location = new System.Drawing.Point(660, 120);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(100, 45);
            this.ShowMenu.TabIndex = 29;
            this.ShowMenu.Text = "Показать меню";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // dichName
            // 
            this.dichName.AutoSize = true;
            this.dichName.BackColor = System.Drawing.Color.Transparent;
            this.dichName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dichName.Location = new System.Drawing.Point(63, 95);
            this.dichName.Name = "dichName";
            this.dichName.Size = new System.Drawing.Size(161, 18);
            this.dichName.TabIndex = 31;
            this.dichName.Text = "Наименование блюда";
            // 
            // ComBox
            // 
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(264, 96);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(266, 21);
            this.ComBox.TabIndex = 32;
            this.ComBox.SelectedIndexChanged += new System.EventHandler(this.ComBox_SelectedIndexChanged);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delete_button.Location = new System.Drawing.Point(660, 64);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 30);
            this.delete_button.TabIndex = 33;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DeleteDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.ComBox);
            this.Controls.Add(this.dichName);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.ShowMenu);
            this.Name = "DeleteDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDish";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid dgMenu;
        private System.Windows.Forms.Button ShowMenu;
        private System.Windows.Forms.Label dichName;
        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Button delete_button;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button backButton;
    }
}