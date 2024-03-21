using System;
using System.Drawing;
using System.Windows.Forms;

namespace PedraPapelOuTesoura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Mensagem(int pontosPC, int pontosUsuario)
        {
            if (pontosPC == 1 && pontosPC > pontosUsuario)
            {
                return "Pelo jeito, é máquina";
            }
            if (pontosUsuario == 1 && pontosUsuario > pontosPC)
            {
                return "Boa jogada!";
            }
            if (pontosPC == 2 && pontosPC > pontosUsuario)
            {
                return "Vai perder para um algoritmo?";
            }
            if (pontosUsuario == 2 && pontosUsuario > pontosPC)
            {
                return "Dá para ganhar!";
            }
            if (pontosPC == 3)
            {
                return "A revolução das máquinas começou :(";
            }
            if (pontosUsuario == 3)
            {
                return "Vitória dos melhores :D";
            }
            if (pontosUsuario == pontosPC)
            {
                return "Hmmm ta estranho isso aí, hein?";
            }
            return "Será que vai dar empate?";
        }
        private int ContarPlacar(string placar)
        {
            switch (placar)
            {
                case "0":
                    return 1;
                case "1":
                    return 2;
                case "2":
                    return 3;
                default:
                    return 0;
            }
        }
        private void BtnJogar_Click(object sender, EventArgs e)
        {
            Random limite = new Random();
            int pc = limite.Next(4);
            if (pc == 0)
            {
                pc = limite.Next(4);
            }
            switch (pc)
            {
                case 1:
                    //pctRespostaPC.Load("../Debug/Imagens/pedraPC.png");
                    pctRespostaPC.Image = rdoPedra.Image;
                    break;
                case 2:
                    //pctRespostaPC.Load("../Debug/Imagens/papelPC.png");
                    pctRespostaPC.Image = rdoPapel.Image;
                    break;
                case 3:
                    //pctRespostaPC.Load("../Debug/Imagens/tesouraPC.jpg");
                    pctRespostaPC.Image = rdoTesoura.Image;
                    break;
                default:
                    break;
            }
            int pontosUsuario = 0;
            int pontosPC = 0;
            if (rdoPedra.Checked && pc == 3 || rdoPapel.Checked && pc == 1 || rdoTesoura.Checked && pc == 2)
            {
                pontosUsuario = ContarPlacar(lblPlacarUsuario.Text);
                lblPlacarUsuario.Text = pontosUsuario.ToString();
            }
            else if (pc == 1 && rdoTesoura.Checked || pc == 2 && rdoPedra.Checked || pc == 3 && rdoPapel.Checked)
            {
                pontosPC = ContarPlacar(lblPlacarPC.Text);
                lblPlacarPC.Text = pontosPC.ToString();
            }
            lblTitulo.Text = Mensagem(pontosPC, pontosUsuario);
            if (lblPlacarPC.Text == "3")
            {
                MessageBox.Show("Poxa! Não foi dessa vez :(");
            }
            else if (lblPlacarUsuario.Text == "3")
            {
                MessageBox.Show("Parabéns!! Você venceu :)");
            }

            if (lblPlacarPC.Text == "3" || lblPlacarUsuario.Text == "3")
            {
                lblPlacarPC.Text = "0";
                lblPlacarUsuario.Text = "0";
                lblTitulo.Text = "PEDRA, PAPEL OU TESOURA?";
                pctRespostaPC.Image = null;
            }
        }

        private void RdoPedra_CheckedChanged(object sender, EventArgs e)
        {
            rdoPedra.BackColor = Color.SaddleBrown;
            if (!rdoPedra.Checked)
            {
                rdoPedra.BackColor = Color.Transparent;
            }
        }

        private void RdoPapel_CheckedChanged(object sender, EventArgs e)
        {
            rdoPapel.BackColor = Color.SaddleBrown;
            if (!rdoPapel.Checked)
            {
                rdoPapel.BackColor = Color.Transparent;
            }
        }

        private void RdoTesoura_CheckedChanged(object sender, EventArgs e)
        {
            rdoTesoura.BackColor = Color.SaddleBrown;
            if (!rdoTesoura.Checked)
            {
                rdoTesoura.BackColor = Color.Transparent;
            }
        }

        private void btnJogar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnJogar.PerformClick();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblPlacarPC.Text = "0";
            lblPlacarUsuario.Text = "0";
            lblTitulo.Text = "PEDRA, PAPEL OU TESOURA?";
            pctRespostaPC.Image = null;
        }
    }
}