
namespace PedraPapelOuTesoura
{
    partial class Form1
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
            this.rdoPapel = new System.Windows.Forms.RadioButton();
            this.rdoTesoura = new System.Windows.Forms.RadioButton();
            this.rdoPedra = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pctRespostaPC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlacarUsuario = new System.Windows.Forms.Label();
            this.lblPlacarPC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctRespostaPC)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoPapel
            // 
            this.rdoPapel.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPapel.Image = global::PedraPapelOuTesoura.Properties.Resources.papell;
            this.rdoPapel.Location = new System.Drawing.Point(145, 169);
            this.rdoPapel.Name = "rdoPapel";
            this.rdoPapel.Size = new System.Drawing.Size(110, 110);
            this.rdoPapel.TabIndex = 1;
            this.rdoPapel.UseVisualStyleBackColor = true;
            this.rdoPapel.CheckedChanged += new System.EventHandler(this.RdoPapel_CheckedChanged);
            // 
            // rdoTesoura
            // 
            this.rdoTesoura.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoTesoura.AutoEllipsis = true;
            this.rdoTesoura.Image = global::PedraPapelOuTesoura.Properties.Resources.tesoura;
            this.rdoTesoura.Location = new System.Drawing.Point(267, 169);
            this.rdoTesoura.Name = "rdoTesoura";
            this.rdoTesoura.Size = new System.Drawing.Size(110, 110);
            this.rdoTesoura.TabIndex = 2;
            this.rdoTesoura.TabStop = true;
            this.rdoTesoura.UseVisualStyleBackColor = true;
            this.rdoTesoura.CheckedChanged += new System.EventHandler(this.RdoTesoura_CheckedChanged);
            // 
            // rdoPedra
            // 
            this.rdoPedra.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPedra.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.rdoPedra.Image = global::PedraPapelOuTesoura.Properties.Resources.pedra;
            this.rdoPedra.Location = new System.Drawing.Point(29, 169);
            this.rdoPedra.Name = "rdoPedra";
            this.rdoPedra.Size = new System.Drawing.Size(110, 110);
            this.rdoPedra.TabIndex = 0;
            this.rdoPedra.TabStop = true;
            this.rdoPedra.UseVisualStyleBackColor = false;
            this.rdoPedra.CheckedChanged += new System.EventHandler(this.RdoPedra_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // pctRespostaPC
            // 
            this.pctRespostaPC.Location = new System.Drawing.Point(558, 169);
            this.pctRespostaPC.Name = "pctRespostaPC";
            this.pctRespostaPC.Size = new System.Drawing.Size(110, 110);
            this.pctRespostaPC.TabIndex = 4;
            this.pctRespostaPC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "VOCÊ";
            // 
            // lblPlacarUsuario
            // 
            this.lblPlacarUsuario.AutoSize = true;
            this.lblPlacarUsuario.BackColor = System.Drawing.Color.White;
            this.lblPlacarUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarUsuario.Location = new System.Drawing.Point(343, 81);
            this.lblPlacarUsuario.Name = "lblPlacarUsuario";
            this.lblPlacarUsuario.Size = new System.Drawing.Size(30, 39);
            this.lblPlacarUsuario.TabIndex = 6;
            this.lblPlacarUsuario.Text = "0";
            this.lblPlacarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacarPC
            // 
            this.lblPlacarPC.AutoSize = true;
            this.lblPlacarPC.BackColor = System.Drawing.Color.White;
            this.lblPlacarPC.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarPC.Location = new System.Drawing.Point(429, 81);
            this.lblPlacarPC.Name = "lblPlacarPC";
            this.lblPlacarPC.Size = new System.Drawing.Size(30, 39);
            this.lblPlacarPC.TabIndex = 7;
            this.lblPlacarPC.Text = "0";
            this.lblPlacarPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "PC";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(805, 56);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "PEDRA, PAPEL OU TESOURA?";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(135, 299);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(132, 35);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "&JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            this.btnJogar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnJogar_KeyDown);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(674, 351);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(64, 21);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "&REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Máquina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(750, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlacarPC);
            this.Controls.Add(this.lblPlacarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctRespostaPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoPapel);
            this.Controls.Add(this.rdoTesoura);
            this.Controls.Add(this.rdoPedra);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, papel, ou tesoura?";
            ((System.ComponentModel.ISupportInitialize)(this.pctRespostaPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoPedra;
        private System.Windows.Forms.RadioButton rdoTesoura;
        private System.Windows.Forms.RadioButton rdoPapel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctRespostaPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlacarUsuario;
        private System.Windows.Forms.Label lblPlacarPC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label3;
    }
}

