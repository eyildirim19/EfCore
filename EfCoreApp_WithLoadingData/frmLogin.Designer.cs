namespace EfCoreApp_WithLoadingData
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCalisan = new System.Windows.Forms.RadioButton();
            this.rbMusteri = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "App ID";
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(12, 39);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(170, 23);
            this.txtAppID.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCalisan);
            this.groupBox1.Controls.Add(this.rbMusteri);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Tipi";
            // 
            // rbCalisan
            // 
            this.rbCalisan.AutoSize = true;
            this.rbCalisan.Location = new System.Drawing.Point(107, 16);
            this.rbCalisan.Name = "rbCalisan";
            this.rbCalisan.Size = new System.Drawing.Size(63, 19);
            this.rbCalisan.TabIndex = 1;
            this.rbCalisan.TabStop = true;
            this.rbCalisan.Text = "Çalışan";
            this.rbCalisan.UseVisualStyleBackColor = true;
            // 
            // rbMusteri
            // 
            this.rbMusteri.AutoSize = true;
            this.rbMusteri.Location = new System.Drawing.Point(11, 16);
            this.rbMusteri.Name = "rbMusteri";
            this.rbMusteri.Size = new System.Drawing.Size(65, 19);
            this.rbMusteri.TabIndex = 0;
            this.rbMusteri.TabStop = true;
            this.rbMusteri.Text = "Müşteri";
            this.rbMusteri.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 178);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox txtAppID;
        private GroupBox groupBox1;
        private RadioButton rbCalisan;
        private RadioButton rbMusteri;
    }
}