namespace AplicativoCrudBasico
{
    partial class mskTelefone
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsbNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbSalvar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbExcluir = new System.Windows.Forms.Button();
            this.tstId = new System.Windows.Forms.TextBox();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.tsbTelefone = new System.Windows.Forms.TextBox();
            this.tsbCep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsbNovo
            // 
            this.tsbNovo.Location = new System.Drawing.Point(11, 11);
            this.tsbNovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(74, 53);
            this.tsbNovo.TabIndex = 1;
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.UseVisualStyleBackColor = true;
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.Location = new System.Drawing.Point(89, 11);
            this.tsbSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(74, 53);
            this.tsbSalvar.TabIndex = 4;
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.UseVisualStyleBackColor = true;
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Location = new System.Drawing.Point(167, 11);
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(74, 53);
            this.tsbCancelar.TabIndex = 5;
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.UseVisualStyleBackColor = true;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Location = new System.Drawing.Point(245, 11);
            this.tsbExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(74, 53);
            this.tsbExcluir.TabIndex = 6;
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.UseVisualStyleBackColor = true;
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(415, 28);
            this.tstId.Margin = new System.Windows.Forms.Padding(2);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(171, 20);
            this.tstId.TabIndex = 7;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Location = new System.Drawing.Point(608, 11);
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(74, 53);
            this.tsbBuscar.TabIndex = 8;
            this.tsbBuscar.Text = "tsbBuscar";
            this.tsbBuscar.UseVisualStyleBackColor = true;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 96);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(186, 96);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(460, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(141, 227);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(207, 20);
            this.txtBairro.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(403, 227);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(207, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(622, 227);
            this.txtUf.Margin = new System.Windows.Forms.Padding(2);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(86, 20);
            this.txtUf.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Buscar por id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "UF";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(64, 176);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(582, 20);
            this.txtEndereco.TabIndex = 26;
            // 
            // tsbTelefone
            // 
            this.tsbTelefone.Location = new System.Drawing.Point(64, 282);
            this.tsbTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.tsbTelefone.Name = "tsbTelefone";
            this.tsbTelefone.Size = new System.Drawing.Size(207, 20);
            this.tsbTelefone.TabIndex = 28;
            // 
            // tsbCep
            // 
            this.tsbCep.Location = new System.Drawing.Point(64, 227);
            this.tsbCep.Margin = new System.Windows.Forms.Padding(2);
            this.tsbCep.Name = "tsbCep";
            this.tsbCep.Size = new System.Drawing.Size(61, 20);
            this.tsbCep.TabIndex = 29;
            // 
            // mskTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 346);
            this.Controls.Add(this.tsbCep);
            this.Controls.Add(this.tsbTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.tsbExcluir);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsbNovo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mskTelefone";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mskTelefone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tsbNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tsbSalvar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbExcluir;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox tsbTelefone;
        private System.Windows.Forms.TextBox tsbCep;
    }
}

