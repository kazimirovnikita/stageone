
namespace Kursach
{
    partial class StatusOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusOrders));
            this.ord_number = new System.Windows.Forms.Label();
            this.idorder = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.bill_button = new System.Windows.Forms.Button();
            this.dgOrder = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.billBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ord_number
            // 
            this.ord_number.AutoSize = true;
            this.ord_number.BackColor = System.Drawing.Color.Transparent;
            this.ord_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ord_number.Location = new System.Drawing.Point(91, 148);
            this.ord_number.Name = "ord_number";
            this.ord_number.Size = new System.Drawing.Size(107, 18);
            this.ord_number.TabIndex = 26;
            this.ord_number.Text = "Номер заказа";
            // 
            // idorder
            // 
            this.idorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.idorder.FormattingEnabled = true;
            this.idorder.Location = new System.Drawing.Point(231, 145);
            this.idorder.Name = "idorder";
            this.idorder.Size = new System.Drawing.Size(57, 26);
            this.idorder.TabIndex = 27;
            this.idorder.SelectedIndexChanged += new System.EventHandler(this.idorder_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(90, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Статус заказа";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.status.Location = new System.Drawing.Point(231, 193);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(117, 24);
            this.status.TabIndex = 41;
            // 
            // bill_button
            // 
            this.bill_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bill_button.Location = new System.Drawing.Point(140, 295);
            this.bill_button.Name = "bill_button";
            this.bill_button.Size = new System.Drawing.Size(148, 30);
            this.bill_button.TabIndex = 45;
            this.bill_button.Text = "Рассчитать заказ";
            this.bill_button.UseVisualStyleBackColor = true;
            this.bill_button.Click += new System.EventHandler(this.bill_button_Click);
            // 
            // dgOrder
            // 
            this.dgOrder.DataMember = "";
            this.dgOrder.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgOrder.Location = new System.Drawing.Point(412, 12);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.Size = new System.Drawing.Size(388, 438);
            this.dgOrder.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(156, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Счёт";
            // 
            // billBox
            // 
            this.billBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.billBox.Location = new System.Drawing.Point(231, 236);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(117, 24);
            this.billBox.TabIndex = 41;
            // 
            // StatusOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgOrder);
            this.Controls.Add(this.bill_button);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.idorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ord_number);
            this.Name = "StatusOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ord_number;
        private System.Windows.Forms.ComboBox idorder;
        private System.Windows.Forms.Button backButton;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button bill_button;
        private System.Windows.Forms.DataGrid dgOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billBox;
    }
}