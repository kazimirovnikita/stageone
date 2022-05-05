
namespace Kursach
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.back_button = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGrid();
            this.inf = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 30);
            this.back_button.TabIndex = 48;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // dg
            // 
            this.dg.DataMember = "";
            this.dg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dg.Location = new System.Drawing.Point(12, 133);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(776, 305);
            this.dg.TabIndex = 49;
            // 
            // inf
            // 
            this.inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inf.FormattingEnabled = true;
            this.inf.Location = new System.Drawing.Point(169, 71);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(312, 26);
            this.inf.TabIndex = 50;
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.show.Location = new System.Drawing.Point(537, 68);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(100, 30);
            this.show.TabIndex = 51;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.back_button);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGrid dg;
        private System.Windows.Forms.ComboBox inf;
        private System.Windows.Forms.Button show;
        private System.Data.OleDb.OleDbConnection cn;
    }
}