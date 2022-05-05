
namespace Kursach
{
    partial class Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.comment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.ComboBox();
            this.ord_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // comment
            // 
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comment.Location = new System.Drawing.Point(286, 215);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(382, 24);
            this.comment.TabIndex = 43;
            this.comment.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(156, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Коментарий";
            // 
            // rating
            // 
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rating.FormattingEnabled = true;
            this.rating.Location = new System.Drawing.Point(286, 161);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(57, 26);
            this.rating.TabIndex = 45;
            // 
            // ord_number
            // 
            this.ord_number.AutoSize = true;
            this.ord_number.BackColor = System.Drawing.Color.Transparent;
            this.ord_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ord_number.Location = new System.Drawing.Point(189, 161);
            this.ord_number.Name = "ord_number";
            this.ord_number.Size = new System.Drawing.Size(60, 18);
            this.ord_number.TabIndex = 44;
            this.ord_number.Text = "Оценка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(199, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Оцените ресторан и добавть комментарий";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 30);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add_button.Location = new System.Drawing.Point(335, 284);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 45);
            this.add_button.TabIndex = 48;
            this.add_button.Text = "Добавить отзыв";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ord_number);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label1);
            this.Name = "Review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rating;
        private System.Windows.Forms.Label ord_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button add_button;
        private System.Data.OleDb.OleDbConnection cn;
    }
}