namespace PersonelGiris
{
    partial class frmPerGos
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
            this.grdPerGos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmlAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPoz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlBolumid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerGos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPerGos
            // 
            this.grdPerGos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPerGos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerGos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmlAd,
            this.cmlSoyad,
            this.clmTc,
            this.clmSicilNo,
            this.cmlYas,
            this.clmPoz,
            this.cmlBolumid});
            this.grdPerGos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdPerGos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdPerGos.Location = new System.Drawing.Point(0, 0);
            this.grdPerGos.Name = "grdPerGos";
            this.grdPerGos.RowHeadersWidth = 80;
            this.grdPerGos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPerGos.Size = new System.Drawing.Size(845, 265);
            this.grdPerGos.TabIndex = 0;
            this.grdPerGos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPerGos_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(420, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yapılan Değişiklikleri kayıt et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranacak personel adı:";
            // 
            // cmlAd
            // 
            this.cmlAd.DataPropertyName = "Ad";
            this.cmlAd.HeaderText = "Ad";
            this.cmlAd.Name = "cmlAd";
            // 
            // cmlSoyad
            // 
            this.cmlSoyad.DataPropertyName = "Soyad";
            this.cmlSoyad.HeaderText = "Soyad";
            this.cmlSoyad.Name = "cmlSoyad";
            // 
            // clmTc
            // 
            this.clmTc.DataPropertyName = "Tc";
            this.clmTc.HeaderText = "Tc";
            this.clmTc.Name = "clmTc";
            // 
            // clmSicilNo
            // 
            this.clmSicilNo.DataPropertyName = "SicilNo";
            this.clmSicilNo.HeaderText = "SicilNo";
            this.clmSicilNo.Name = "clmSicilNo";
            // 
            // cmlYas
            // 
            this.cmlYas.DataPropertyName = "Yas";
            this.cmlYas.HeaderText = "Yas";
            this.cmlYas.Name = "cmlYas";
            // 
            // clmPoz
            // 
            this.clmPoz.DataPropertyName = "Pozisyon";
            this.clmPoz.HeaderText = "Pozisyon";
            this.clmPoz.Name = "clmPoz";
            // 
            // cmlBolumid
            // 
            this.cmlBolumid.DataPropertyName = "Bolumid";
            this.cmlBolumid.HeaderText = "Bolum ad";
            this.cmlBolumid.Name = "cmlBolumid";
            this.cmlBolumid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmPerGos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdPerGos);
            this.Name = "frmPerGos";
            this.Text = "frmPerGos";
            this.Load += new System.EventHandler(this.frmPerGos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPerGos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPerGos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlYas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPoz;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmlBolumid;
    }
}