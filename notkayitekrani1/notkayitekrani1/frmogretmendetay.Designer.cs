
namespace notkayitekrani1
{
    partial class frmogretmendetay
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxnumara = new System.Windows.Forms.MaskedTextBox();
            this.txtkayitad = new System.Windows.Forms.TextBox();
            this.txtkayitsoyad = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtnotgiriss3 = new System.Windows.Forms.TextBox();
            this.txtnotgiriss2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnotgiriss1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblort = new System.Windows.Forms.Label();
            this.lblgecensayisi = new System.Windows.Forms.Label();
            this.lblkalansayisi = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbnotkayitDataSet = new notkayitekrani1.dbnotkayitDataSet();
            this.tbldersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_dersTableAdapter = new notkayitekrani1.dbnotkayitDataSetTableAdapters.tbl_dersTableAdapter();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrs1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrs2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrs3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.txtkayitsoyad);
            this.groupBox1.Controls.Add(this.txtkayitad);
            this.groupBox1.Controls.Add(this.maskedTextBoxnumara);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // maskedTextBoxnumara
            // 
            this.maskedTextBoxnumara.Location = new System.Drawing.Point(120, 53);
            this.maskedTextBoxnumara.Mask = "0000";
            this.maskedTextBoxnumara.Name = "maskedTextBoxnumara";
            this.maskedTextBoxnumara.Size = new System.Drawing.Size(100, 32);
            this.maskedTextBoxnumara.TabIndex = 3;
            this.maskedTextBoxnumara.ValidatingType = typeof(int);
            // 
            // txtkayitad
            // 
            this.txtkayitad.Location = new System.Drawing.Point(120, 92);
            this.txtkayitad.Name = "txtkayitad";
            this.txtkayitad.Size = new System.Drawing.Size(100, 32);
            this.txtkayitad.TabIndex = 4;
            // 
            // txtkayitsoyad
            // 
            this.txtkayitsoyad.Location = new System.Drawing.Point(120, 130);
            this.txtkayitsoyad.Name = "txtkayitsoyad";
            this.txtkayitsoyad.Size = new System.Drawing.Size(100, 32);
            this.txtkayitsoyad.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(87, 181);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(87, 33);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnotgiriss1);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.txtnotgiriss3);
            this.groupBox2.Controls.Add(this.txtnotgiriss2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 220);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Giriş";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(69, 181);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(118, 33);
            this.btnguncelle.TabIndex = 6;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtnotgiriss3
            // 
            this.txtnotgiriss3.Location = new System.Drawing.Point(87, 130);
            this.txtnotgiriss3.Name = "txtnotgiriss3";
            this.txtnotgiriss3.Size = new System.Drawing.Size(100, 32);
            this.txtnotgiriss3.TabIndex = 5;
            // 
            // txtnotgiriss2
            // 
            this.txtnotgiriss2.Location = new System.Drawing.Point(87, 92);
            this.txtnotgiriss2.Name = "txtnotgiriss2";
            this.txtnotgiriss2.Size = new System.Drawing.Size(100, 32);
            this.txtnotgiriss2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "S3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "S2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "S1:";
            // 
            // txtnotgiriss1
            // 
            this.txtnotgiriss1.Location = new System.Drawing.Point(87, 54);
            this.txtnotgiriss1.Name = "txtnotgiriss1";
            this.txtnotgiriss1.Size = new System.Drawing.Size(100, 32);
            this.txtnotgiriss1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblkalansayisi);
            this.groupBox3.Controls.Add(this.lblgecensayisi);
            this.groupBox3.Controls.Add(this.lblort);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(536, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 220);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not Giriş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama:";
            // 
            // lblort
            // 
            this.lblort.AutoSize = true;
            this.lblort.Location = new System.Drawing.Point(167, 54);
            this.lblort.Name = "lblort";
            this.lblort.Size = new System.Drawing.Size(30, 24);
            this.lblort.TabIndex = 3;
            this.lblort.Text = "00";
            // 
            // lblgecensayisi
            // 
            this.lblgecensayisi.AutoSize = true;
            this.lblgecensayisi.Location = new System.Drawing.Point(167, 92);
            this.lblgecensayisi.Name = "lblgecensayisi";
            this.lblgecensayisi.Size = new System.Drawing.Size(30, 24);
            this.lblgecensayisi.TabIndex = 4;
            this.lblgecensayisi.Text = "00";
            // 
            // lblkalansayisi
            // 
            this.lblkalansayisi.AutoSize = true;
            this.lblkalansayisi.Location = new System.Drawing.Point(167, 130);
            this.lblkalansayisi.Name = "lblkalansayisi";
            this.lblkalansayisi.Size = new System.Drawing.Size(30, 24);
            this.lblkalansayisi.TabIndex = 5;
            this.lblkalansayisi.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(788, 170);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrnumaraDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrs1DataGridViewTextBoxColumn,
            this.ogrs2DataGridViewTextBoxColumn,
            this.ogrs3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tbldersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbnotkayitDataSet
            // 
            this.dbnotkayitDataSet.DataSetName = "dbnotkayitDataSet";
            this.dbnotkayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldersBindingSource
            // 
            this.tbldersBindingSource.DataMember = "tbl_ders";
            this.tbldersBindingSource.DataSource = this.dbnotkayitDataSet;
            // 
            // tbl_dersTableAdapter
            // 
            this.tbl_dersTableAdapter.ClearBeforeFill = true;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrnumaraDataGridViewTextBoxColumn
            // 
            this.ogrnumaraDataGridViewTextBoxColumn.DataPropertyName = "ogrnumara";
            this.ogrnumaraDataGridViewTextBoxColumn.HeaderText = "ogrnumara";
            this.ogrnumaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrnumaraDataGridViewTextBoxColumn.Name = "ogrnumaraDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogrs1DataGridViewTextBoxColumn
            // 
            this.ogrs1DataGridViewTextBoxColumn.DataPropertyName = "ogrs1";
            this.ogrs1DataGridViewTextBoxColumn.HeaderText = "ogrs1";
            this.ogrs1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrs1DataGridViewTextBoxColumn.Name = "ogrs1DataGridViewTextBoxColumn";
            // 
            // ogrs2DataGridViewTextBoxColumn
            // 
            this.ogrs2DataGridViewTextBoxColumn.DataPropertyName = "ogrs2";
            this.ogrs2DataGridViewTextBoxColumn.HeaderText = "ogrs2";
            this.ogrs2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrs2DataGridViewTextBoxColumn.Name = "ogrs2DataGridViewTextBoxColumn";
            // 
            // ogrs3DataGridViewTextBoxColumn
            // 
            this.ogrs3DataGridViewTextBoxColumn.DataPropertyName = "ogrs3";
            this.ogrs3DataGridViewTextBoxColumn.HeaderText = "ogrs3";
            this.ogrs3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrs3DataGridViewTextBoxColumn.Name = "ogrs3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // frmogretmendetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmogretmendetay";
            this.Text = "frmogretmendetay";
            this.Load += new System.EventHandler(this.frmogretmendetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtkayitsoyad;
        private System.Windows.Forms.TextBox txtkayitad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxnumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtnotgiriss3;
        private System.Windows.Forms.TextBox txtnotgiriss2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblkalansayisi;
        private System.Windows.Forms.Label lblgecensayisi;
        private System.Windows.Forms.Label lblort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnotgiriss1;
        private dbnotkayitDataSet dbnotkayitDataSet;
        private System.Windows.Forms.BindingSource tbldersBindingSource;
        private dbnotkayitDataSetTableAdapters.tbl_dersTableAdapter tbl_dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrs1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrs2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrs3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}