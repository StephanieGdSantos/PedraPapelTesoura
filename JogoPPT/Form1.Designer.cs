
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
            ((System.ComponentModel.ISupportInitialize)(this.pctRespostaPC)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoPapel
            // 
            this.rdoPapel.AutoSize = true;
            this.rdoPapel.Image = global::PedraPapelOuTesoura.Properties.Resources.papell;
            this.rdoPapel.Location = new System.Drawing.Point(52, 280);
            this.rdoPapel.Name = "rdoPapel";
            this.rdoPapel.Size = new System.Drawing.Size(134, 120);
            this.rdoPapel.TabIndex = 1;
            this.rdoPapel.TabStop = true;
            this.rdoPapel.UseVisualStyleBackColor = true;
            this.rdoPapel.CheckedChanged += new System.EventHandler(this.RdoPapel_CheckedChanged);
            // 
            // rdoTesoura
            // 
            this.rdoTesoura.AutoSize = true;
            this.rdoTesoura.Image = global::PedraPapelOuTesoura.Properties.Resources.tesoura;
            this.rdoTesoura.Location = new System.Drawing.Point(52, 406);
            this.rdoTesoura.Name = "rdoTesoura";
            this.rdoTesoura.Size = new System.Drawing.Size(134, 120);
            this.rdoTesoura.TabIndex = 2;
            this.rdoTesoura.TabStop = true;
            this.rdoTesoura.UseVisualStyleBackColor = true;
            this.rdoTesoura.CheckedChanged += new System.EventHandler(this.RdoTesoura_CheckedChanged);
            // 
            // rdoPedra
            // 
            this.rdoPedra.AutoSize = true;
            this.rdoPedra.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.rdoPedra.Image = global::PedraPapelOuTesoura.Properties.Resources.pedra;
            this.rdoPedra.Location = new System.Drawing.Point(52, 159);
            this.rdoPedra.Name = "rdoPedra";
            this.rdoPedra.Size = new System.Drawing.Size(134, 120);
            this.rdoPedra.TabIndex = 0;
            this.rdoPedra.TabStop = true;
            this.rdoPedra.UseVisualStyleBackColor = false;
            this.rdoPedra.CheckedChanged += new System.EventHandler(this.RdoPedra_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 115);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // pctRespostaPC
            // 
            this.pctRespostaPC.Location = new System.Drawing.Point(545, 200);
            this.pctRespostaPC.Name = "pctRespostaPC";
            this.pctRespostaPC.Size = new System.Drawing.Size(200, 200);
            this.pctRespostaPC.TabIndex = 4;
            this.pctRespostaPC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "VOCÊ";
            // 
            // lblPlacarUsuario
            // 
            this.lblPlacarUsuario.AutoSize = true;
            this.lblPlacarUsuario.BackColor = System.Drawing.Color.White;
            this.lblPlacarUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarUsuario.Location = new System.Drawing.Point(274, 97);
            this.lblPlacarUsuario.Name = "lblPlacarUsuario";
            this.lblPlacarUsuario.Size = new System.Drawing.Size(45, 58);
            this.lblPlacarUsuario.TabIndex = 6;
            this.lblPlacarUsuario.Text = "0";
            this.lblPlacarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacarPC
            // 
            this.lblPlacarPC.AutoSize = true;
            this.lblPlacarPC.BackColor = System.Drawing.Color.White;
            this.lblPlacarPC.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarPC.Location = new System.Drawing.Point(477, 97);
            this.lblPlacarPC.Name = "lblPlacarPC";
            this.lblPlacarPC.Size = new System.Drawing.Size(45, 58);
            this.lblPlacarPC.TabIndex = 7;
            this.lblPlacarPC.Text = "0";
            this.lblPlacarPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 58);
            this.label5.TabIndex = 8;
            this.label5.Text = "PC";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(805, 78);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "PEDRA, PAPEL OU TESOURA?";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(337, 430);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(132, 55);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "&JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            this.btnJogar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnJogar_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(802, 566);
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
    }
}

