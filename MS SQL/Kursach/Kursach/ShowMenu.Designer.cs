
namespace Kursach
{
    partial class ShowMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMenu));
            this.button2 = new System.Windows.Forms.Button();
            this.dgMenu = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 39;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgMenu
            // 
            this.dgMenu.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dgMenu.DataMember = "";
            this.dgMenu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMenu.Location = new System.Drawing.Point(2, 62);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(797, 388);
            this.dgMenu.TabIndex = 40;
            // 
            // ShowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.button2);
            this.Name = "ShowMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGrid dgMenu;
        private System.Data.OleDb.OleDbConnection cn;
    }
}