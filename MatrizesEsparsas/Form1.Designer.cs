﻿namespace MatrizesEsparsas
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbOutraMatriz = new System.Windows.Forms.GroupBox();
            this.btnMultiplicarMatriz = new System.Windows.Forms.Button();
            this.btnSomarMatriz = new System.Windows.Forms.Button();
            this.btnAbrirDois = new System.Windows.Forms.Button();
            this.btnSomarK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnMultiplicarK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.grbOutraMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(14, 77);
            this.dgvMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(485, 417);
            this.dgvMatriz.TabIndex = 0;
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(137, 16);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 44);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grbOutraMatriz
            // 
            this.grbOutraMatriz.Controls.Add(this.btnMultiplicarMatriz);
            this.grbOutraMatriz.Controls.Add(this.btnSomarMatriz);
            this.grbOutraMatriz.Controls.Add(this.btnAbrirDois);
            this.grbOutraMatriz.Location = new System.Drawing.Point(507, 174);
            this.grbOutraMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbOutraMatriz.Name = "grbOutraMatriz";
            this.grbOutraMatriz.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbOutraMatriz.Size = new System.Drawing.Size(313, 88);
            this.grbOutraMatriz.TabIndex = 3;
            this.grbOutraMatriz.TabStop = false;
            this.grbOutraMatriz.Text = "Outra Matriz";
            // 
            // btnMultiplicarMatriz
            // 
            this.btnMultiplicarMatriz.Enabled = false;
            this.btnMultiplicarMatriz.Location = new System.Drawing.Point(216, 29);
            this.btnMultiplicarMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiplicarMatriz.Name = "btnMultiplicarMatriz";
            this.btnMultiplicarMatriz.Size = new System.Drawing.Size(88, 42);
            this.btnMultiplicarMatriz.TabIndex = 2;
            this.btnMultiplicarMatriz.Text = "Multiplicar";
            this.btnMultiplicarMatriz.UseVisualStyleBackColor = true;
            // 
            // btnSomarMatriz
            // 
            this.btnSomarMatriz.Enabled = false;
            this.btnSomarMatriz.Location = new System.Drawing.Point(122, 29);
            this.btnSomarMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSomarMatriz.Name = "btnSomarMatriz";
            this.btnSomarMatriz.Size = new System.Drawing.Size(88, 42);
            this.btnSomarMatriz.TabIndex = 1;
            this.btnSomarMatriz.Text = "Somar";
            this.btnSomarMatriz.UseVisualStyleBackColor = true;
            // 
            // btnAbrirDois
            // 
            this.btnAbrirDois.Location = new System.Drawing.Point(7, 29);
            this.btnAbrirDois.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirDois.Name = "btnAbrirDois";
            this.btnAbrirDois.Size = new System.Drawing.Size(108, 42);
            this.btnAbrirDois.TabIndex = 0;
            this.btnAbrirDois.Text = "Abrir Arquivo 2";
            this.btnAbrirDois.UseVisualStyleBackColor = true;
            // 
            // btnSomarK
            // 
            this.btnSomarK.Location = new System.Drawing.Point(509, 118);
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
            this.label1.Location = new System.Drawing.Point(510, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Constante K:";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(514, 87);
            this.txtK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(116, 25);
            this.txtK.TabIndex = 6;
            // 
            // btnMultiplicarK
            // 
            this.btnMultiplicarK.Location = new System.Drawing.Point(610, 118);
            this.btnMultiplicarK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiplicarK.Name = "btnMultiplicarK";
            this.btnMultiplicarK.Size = new System.Drawing.Size(102, 36);
            this.btnMultiplicarK.TabIndex = 7;
            this.btnMultiplicarK.Text = "Multiplicar";
            this.btnMultiplicarK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(669, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coluna:";
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(673, 87);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(100, 25);
            this.txtColuna.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(514, 286);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 45);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar Matriz";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 504);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtColuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMultiplicarK);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSomarK);
            this.Controls.Add(this.grbOutraMatriz);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.dgvMatriz);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMatrizEsparsa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.grbOutraMatriz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.OpenFileDialog dlgAbrirArq;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grbOutraMatriz;
        private System.Windows.Forms.Button btnMultiplicarMatriz;
        private System.Windows.Forms.Button btnSomarMatriz;
        private System.Windows.Forms.Button btnAbrirDois;
        private System.Windows.Forms.Button btnSomarK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnMultiplicarK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Button btnLimpar;
    }
}

