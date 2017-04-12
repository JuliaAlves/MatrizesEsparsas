namespace MatrizesEsparsas
{
    partial class frmMatrizEsparsa
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
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.dlgAbrirArq = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.grbOutraMatriz = new System.Windows.Forms.GroupBox();
            this.btnMultiplicarMatriz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSomarMatriz = new System.Windows.Forms.Button();
            this.btnAbrirDois = new System.Windows.Forms.Button();
            this.btnSomarK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.grbOutraMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            this.dgvMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(4, 60);
            this.dgvMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.Size = new System.Drawing.Size(474, 296);
            this.dgvMatriz.TabIndex = 0;
            this.dgvMatriz.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellValueChanged);
            // 
            // dlgAbrirArq
            // 
            this.dlgAbrirArq.DefaultExt = "*.txt";
            this.dlgAbrirArq.FileName = "openFileDialog1";
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(14, 16);
            this.btnAbrirArquivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(105, 44);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "Abrir Arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.DefaultExt = "*.txt";
            // 
            // grbOutraMatriz
            // 
            this.grbOutraMatriz.Controls.Add(this.btnMultiplicarMatriz);
            this.grbOutraMatriz.Controls.Add(this.dataGridView1);
            this.grbOutraMatriz.Controls.Add(this.btnSomarMatriz);
            this.grbOutraMatriz.Controls.Add(this.btnAbrirDois);
            this.grbOutraMatriz.Location = new System.Drawing.Point(512, 7);
            this.grbOutraMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbOutraMatriz.Name = "grbOutraMatriz";
            this.grbOutraMatriz.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbOutraMatriz.Size = new System.Drawing.Size(496, 364);
            this.grbOutraMatriz.TabIndex = 3;
            this.grbOutraMatriz.TabStop = false;
            this.grbOutraMatriz.Text = "Outra Matriz";
            // 
            // btnMultiplicarMatriz
            // 
            this.btnMultiplicarMatriz.Enabled = false;
            this.btnMultiplicarMatriz.Location = new System.Drawing.Point(216, 18);
            this.btnMultiplicarMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiplicarMatriz.Name = "btnMultiplicarMatriz";
            this.btnMultiplicarMatriz.Size = new System.Drawing.Size(88, 38);
            this.btnMultiplicarMatriz.TabIndex = 2;
            this.btnMultiplicarMatriz.Text = "Multiplicar";
            this.btnMultiplicarMatriz.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatriz.Click += new System.EventHandler(this.btnMultiplicarMatriz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 294);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSomarMatriz
            // 
            this.btnSomarMatriz.Enabled = false;
            this.btnSomarMatriz.Location = new System.Drawing.Point(120, 18);
            this.btnSomarMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSomarMatriz.Name = "btnSomarMatriz";
            this.btnSomarMatriz.Size = new System.Drawing.Size(88, 34);
            this.btnSomarMatriz.TabIndex = 1;
            this.btnSomarMatriz.Text = "Somar";
            this.btnSomarMatriz.UseVisualStyleBackColor = true;
            this.btnSomarMatriz.Click += new System.EventHandler(this.btnSomarMatriz_Click);
            // 
            // btnAbrirDois
            // 
            this.btnAbrirDois.Location = new System.Drawing.Point(6, 18);
            this.btnAbrirDois.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirDois.Name = "btnAbrirDois";
            this.btnAbrirDois.Size = new System.Drawing.Size(108, 34);
            this.btnAbrirDois.TabIndex = 0;
            this.btnAbrirDois.Text = "Abrir Arquivo 2";
            this.btnAbrirDois.UseVisualStyleBackColor = true;
            this.btnAbrirDois.Click += new System.EventHandler(this.btnAbrirDois_Click);
            // 
            // btnSomarK
            // 
            this.btnSomarK.Location = new System.Drawing.Point(395, 9);
            this.btnSomarK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSomarK.Name = "btnSomarK";
            this.btnSomarK.Size = new System.Drawing.Size(94, 36);
            this.btnSomarK.TabIndex = 4;
            this.btnSomarK.Text = "Somar";
            this.btnSomarK.UseVisualStyleBackColor = true;
            this.btnSomarK.Click += new System.EventHandler(this.btnSomarK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Constante K:";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(210, 28);
            this.txtK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(69, 25);
            this.txtK.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(317, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coluna:";
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(320, 29);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(59, 25);
            this.txtColuna.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(126, 16);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 45);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar Matriz";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 388);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(466, 271);
            this.dataGridView2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtK);
            this.panel1.Controls.Add(this.btnSomarK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtColuna);
            this.panel1.Controls.Add(this.dgvMatriz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 364);
            this.panel1.TabIndex = 13;
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 671);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grbOutraMatriz);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMatrizEsparsa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.grbOutraMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.OpenFileDialog dlgAbrirArq;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.GroupBox grbOutraMatriz;
        private System.Windows.Forms.Button btnMultiplicarMatriz;
        private System.Windows.Forms.Button btnSomarMatriz;
        private System.Windows.Forms.Button btnAbrirDois;
        private System.Windows.Forms.Button btnSomarK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
    }
}

