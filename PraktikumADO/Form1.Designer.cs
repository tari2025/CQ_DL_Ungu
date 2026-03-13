namespace PraktikumADO
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHitungDosen = new System.Windows.Forms.Button();
            this.btnUpdateMK = new System.Windows.Forms.Button();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 150);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 43);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(149, 154);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(113, 39);
            this.btnHitungMhs.TabIndex = 3;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(287, 150);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(127, 39);
            this.btnHitungMK.TabIndex = 4;
            this.btnHitungMK.Text = "Hitung MK";
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(449, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(125, 36);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(200, 26);
            this.txtHasil.TabIndex = 1;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasil";
            // 
            // btnHitungDosen
            // 
            this.btnHitungDosen.Location = new System.Drawing.Point(125, 223);
            this.btnHitungDosen.Name = "btnHitungDosen";
            this.btnHitungDosen.Size = new System.Drawing.Size(108, 30);
            this.btnHitungDosen.TabIndex = 6;
            this.btnHitungDosen.Text = "Hitun Dosen";
            this.btnHitungDosen.UseVisualStyleBackColor = true;
            this.btnHitungDosen.Click += new System.EventHandler(this.btnHitungDosen_Click);
            // 
            // btnUpdateMK
            // 
            this.btnUpdateMK.Location = new System.Drawing.Point(287, 223);
            this.btnUpdateMK.Name = "btnUpdateMK";
            this.btnUpdateMK.Size = new System.Drawing.Size(101, 30);
            this.btnUpdateMK.TabIndex = 7;
            this.btnUpdateMK.Text = "Update MK";
            this.btnUpdateMK.UseVisualStyleBackColor = true;
            this.btnUpdateMK.Click += new System.EventHandler(this.btnUpdateMK_Click);
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(416, 223);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(106, 30);
            this.btnInsertProdi.TabIndex = 8;
            this.btnInsertProdi.Text = "Insert Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.btnInsertProdi_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.btnUpdateMK);
            this.Controls.Add(this.btnHitungDosen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "ADO.NET Praktikum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnHitungDosen;
        private System.Windows.Forms.Button btnUpdateMK;
        private System.Windows.Forms.Button btnInsertProdi;
    }
}