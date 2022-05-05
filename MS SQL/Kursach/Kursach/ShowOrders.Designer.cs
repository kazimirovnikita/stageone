
namespace Kursach
{
    partial class ShowOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOrders));
            this.dg = new System.Windows.Forms.DataGrid();
            this.back_button = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.DataMember = "";
            this.dg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dg.Location = new System.Drawing.Point(12, 70);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(776, 368);
            this.dg.TabIndex = 55;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 30);
            this.back_button.TabIndex = 58;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ShowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dg);
            this.Name = "ShowOrders";
            this.Text = "ShowOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGrid dg;
        private System.Windows.Forms.Button back_button;
        private System.Data.OleDb.OleDbConnection cn;
    }
}