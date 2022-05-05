
namespace Kursach
{
    partial class Admin_menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_menu));
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.Button();
            this.showReview = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add.Location = new System.Drawing.Point(302, 63);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 49);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить сотрудника";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delete.Location = new System.Drawing.Point(302, 156);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 49);
            this.delete.TabIndex = 0;
            this.delete.Text = "Уволить сотрудника";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Stat
            // 
            this.Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Stat.Location = new System.Drawing.Point(302, 246);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(159, 49);
            this.Stat.TabIndex = 0;
            this.Stat.Text = "Статистика";
            this.Stat.UseVisualStyleBackColor = true;
            this.Stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // showReview
            // 
            this.showReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.showReview.Location = new System.Drawing.Point(302, 333);
            this.showReview.Name = "showReview";
            this.showReview.Size = new System.Drawing.Size(159, 49);
            this.showReview.TabIndex = 2;
            this.showReview.Text = "Посмотреть отзывы";
            this.showReview.UseVisualStyleBackColor = true;
            this.showReview.Click += new System.EventHandler(this.showReview_Click);
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
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.showReview);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Admin_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню администратора";
            this.Load += new System.EventHandler(this.Admin_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Button showReview;
        private System.Windows.Forms.Button backButton;
    }
}

