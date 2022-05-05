
namespace Kursach
{
    partial class Menu_vivsitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_vivsitor));
            this.review = new System.Windows.Forms.Button();
            this.showOrder = new System.Windows.Forms.Button();
            this.newDish = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // review
            // 
            this.review.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.review.Location = new System.Drawing.Point(302, 333);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(159, 49);
            this.review.TabIndex = 4;
            this.review.Text = "Оставить отзыв";
            this.review.UseVisualStyleBackColor = true;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // showOrder
            // 
            this.showOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.showOrder.Location = new System.Drawing.Point(302, 246);
            this.showOrder.Name = "showOrder";
            this.showOrder.Size = new System.Drawing.Size(159, 49);
            this.showOrder.TabIndex = 5;
            this.showOrder.Text = "Посмотреть свои заказы";
            this.showOrder.UseVisualStyleBackColor = true;
            this.showOrder.Click += new System.EventHandler(this.showOrder_Click);
            // 
            // newDish
            // 
            this.newDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.newDish.Location = new System.Drawing.Point(302, 156);
            this.newDish.Name = "newDish";
            this.newDish.Size = new System.Drawing.Size(159, 49);
            this.newDish.TabIndex = 6;
            this.newDish.Text = "Добавить блюдо к заказу";
            this.newDish.UseVisualStyleBackColor = true;
            this.newDish.Click += new System.EventHandler(this.newDish_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add.Location = new System.Drawing.Point(302, 63);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 49);
            this.add.TabIndex = 7;
            this.add.Text = "Сделать заказ";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            // Menu_vivsitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.review);
            this.Controls.Add(this.showOrder);
            this.Controls.Add(this.newDish);
            this.Controls.Add(this.add);
            this.Name = "Menu_vivsitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_visitor";
            this.Load += new System.EventHandler(this.Menu_vivsitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button showOrder;
        private System.Windows.Forms.Button newDish;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button backButton;
    }
}