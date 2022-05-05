
namespace Kursach
{
    partial class Cook_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cook_menu));
            this.changeIng = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.show_status = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeIng
            // 
            this.changeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.changeIng.Location = new System.Drawing.Point(302, 246);
            this.changeIng.Name = "changeIng";
            this.changeIng.Size = new System.Drawing.Size(159, 49);
            this.changeIng.TabIndex = 1;
            this.changeIng.Text = "Изменить состав блюда";
            this.changeIng.UseVisualStyleBackColor = true;
            this.changeIng.Click += new System.EventHandler(this.changeIng_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delete.Location = new System.Drawing.Point(302, 156);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 49);
            this.delete.TabIndex = 2;
            this.delete.Text = "Убрать блюдо из меню";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add.Location = new System.Drawing.Point(302, 63);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 49);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить блюдо в меню";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // show_status
            // 
            this.show_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.show_status.Location = new System.Drawing.Point(302, 333);
            this.show_status.Name = "show_status";
            this.show_status.Size = new System.Drawing.Size(159, 49);
            this.show_status.TabIndex = 1;
            this.show_status.Text = "Посмотреть статус заказов";
            this.show_status.UseVisualStyleBackColor = true;
            this.show_status.Click += new System.EventHandler(this.show_status_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Cook_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.show_status);
            this.Controls.Add(this.changeIng);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Cook_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню повара";
            this.Load += new System.EventHandler(this.Cook_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeIng;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button show_status;
        private System.Windows.Forms.Button backButton;
    }
}