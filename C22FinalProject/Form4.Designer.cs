namespace C22FinalProject
{
    partial class Form4
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
            this.btndlt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrt = new System.Windows.Forms.TextBox();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.almt = new System.Windows.Forms.TextBox();
            this.nmp = new System.Windows.Forms.TextBox();
            this.idp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndlt
            // 
            this.btndlt.Location = new System.Drawing.Point(562, 447);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(105, 40);
            this.btndlt.TabIndex = 14;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nomor Telepon";
            // 
            // nmrt
            // 
            this.nmrt.Location = new System.Drawing.Point(215, 397);
            this.nmrt.Name = "nmrt";
            this.nmrt.Size = new System.Drawing.Size(452, 31);
            this.nmrt.TabIndex = 12;
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(387, 447);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(105, 40);
            this.btnup.TabIndex = 10;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(215, 447);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 40);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(683, 25);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(105, 40);
            this.btnopen.TabIndex = 7;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(637, 209);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // almt
            // 
            this.almt.Location = new System.Drawing.Point(215, 347);
            this.almt.Name = "almt";
            this.almt.Size = new System.Drawing.Size(452, 31);
            this.almt.TabIndex = 5;
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(215, 299);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(452, 31);
            this.nmp.TabIndex = 4;
            this.nmp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // idp
            // 
            this.idp.Location = new System.Drawing.Point(215, 253);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(452, 31);
            this.idp.TabIndex = 3;
            this.idp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama_Pemilik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Pemilik";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(683, 543);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 595);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.nmrt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.almt);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "PEMILIK";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nmrt;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox almt;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}