namespace EfCoreApp_WithLoadingData
{
    partial class frmCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwOrderDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwOrders);
            this.groupBox1.Location = new System.Drawing.Point(20, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Bilgileri";
            // 
            // dgwOrders
            // 
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.Location = new System.Drawing.Point(6, 22);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.RowTemplate.Height = 25;
            this.dgwOrders.Size = new System.Drawing.Size(721, 176);
            this.dgwOrders.TabIndex = 0;
            this.dgwOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrders_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buraya bir adet grid atılıp seçilen siparş satının sipariş detayı listelenecek. (" +
    "Gridde)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sipariş Detayında (Grid row seçildiğinde) seçildiğinde üÜrün kategori Adı ve Teda" +
    "rikci adı gösterilecek";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(20, 443);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(118, 15);
            this.lblStok.TabIndex = 5;
            this.lblStok.Text = "Kategori Adın buraya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tedarikçi Adı Buraya...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "GridRowSelect veya GridCellClick ile satırı yakaylıp ilgili Id\'yi alabilirsiniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwOrderDetails);
            this.groupBox2.Location = new System.Drawing.Point(19, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 105);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Detayı";
            // 
            // dgwOrderDetails
            // 
            this.dgwOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetails.Location = new System.Drawing.Point(10, 20);
            this.dgwOrderDetails.Name = "dgwOrderDetails";
            this.dgwOrderDetails.RowTemplate.Height = 25;
            this.dgwOrderDetails.Size = new System.Drawing.Size(657, 79);
            this.dgwOrderDetails.TabIndex = 0;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgwOrders;
        private Label label1;
        private Label label2;
        private Label lblStok;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dgwOrderDetails;
    }
}