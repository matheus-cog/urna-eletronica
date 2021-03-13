using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // at first you've to import this package to access SoundPlayer

namespace urnaEletrônica
{
    public partial class btn1 : Form
    {
        // Variáveis para contabilização das votações

        int treze, dezessete, quarentaecinco, dezoito, cinco, seis, branco;

        public btn1()
        {
            InitializeComponent();
            picFoto.Hide();            
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtPrimeiroDigito.Text = "";
            txtSegundoDigito.Text = "";

            txtNome.Text = "";
            txtPartido.Text = "";

            picFoto.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "1";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "2";
            }
            else if(txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "3";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "4";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "5";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "6";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "7";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "8";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "9";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroDigito.Text == "")
            {
                txtPrimeiroDigito.Text = "0";
            }
            else if (txtSegundoDigito.Text == "")
            {
                txtSegundoDigito.Text = "0";
            }
        }

        private void txtSegundoDigito_TextChanged(object sender, EventArgs e)
        {
            if (txtSegundoDigito.Text != "")
            {
                string concatenador;

                concatenador = txtPrimeiroDigito.Text + txtSegundoDigito.Text;
                
                if (concatenador == "05")
                {
                    picFoto.Image = Properties.Resources.Galo_Cego;
                    picFoto.Show();

                    txtNome.Text = "GALO CEGO";
                    txtPartido.Text = "EG - EASTER EGG";
                }

                if (concatenador == "06")
                {
                    picFoto.Image = Properties.Resources.janão;
                    picFoto.Show();

                    txtNome.Text = "JÁ NÃO TAVA MUITO BOM";
                    txtPartido.Text = "EG - EASTER EGG";
                }

                if (concatenador == "13")
                {
                    picFoto.Image = Properties.Resources.haddad;
                    picFoto.Show();

                    txtNome.Text = "FERNANDO HADDAD";
                    txtPartido.Text = "PT";
                }

                if (concatenador == "17")
                {
                    picFoto.Image = Properties.Resources.bolsomito;
                    picFoto.Show();

                    txtNome.Text = "JAIR MESSIAS BOLSONARO";
                    txtPartido.Text = "PSL";
                }

                if (concatenador == "18")
                {
                    picFoto.Image = Properties.Resources.marina;
                    picFoto.Show();

                    txtNome.Text = "MARINA SILVA";
                    txtPartido.Text = "REDE SUSTENTABILIDADE";
                }

                if (concatenador == "45")
                {
                    picFoto.Image = Properties.Resources.aecio;
                    picFoto.Show();

                    txtNome.Text = "AÉCIO NEVES";
                    txtPartido.Text = "PSDB";
                }

            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

            if (txtPrimeiroDigito.Text == "0" && txtSegundoDigito.Text == "5")
            {
                cinco = cinco + 1;
				audio();
				MessageBox.Show("FIM");
			}

            if (txtPrimeiroDigito.Text == "0" && txtSegundoDigito.Text == "6")
            {
                seis = seis + 1;
				audio();
				MessageBox.Show("FIM");
			}

            if (txtPrimeiroDigito.Text == "1" && txtSegundoDigito.Text == "3")
            {
                treze = treze + 1;
				audio();
				MessageBox.Show("FIM");
			}

            if (txtPrimeiroDigito.Text == "1" && txtSegundoDigito.Text == "7")
            {
                dezessete = dezessete + 1;
				audio();
				MessageBox.Show("FIM");
			}

            if (txtPrimeiroDigito.Text == "1" && txtSegundoDigito.Text == "8")
            {
                dezoito = dezoito + 1;
				audio();
				MessageBox.Show("FIM");
			}

            if (txtPrimeiroDigito.Text == "4" && txtSegundoDigito.Text == "5")
            {
                quarentaecinco = quarentaecinco + 1;
				audio();
				MessageBox.Show("FIM");
			}

            if (txtPrimeiroDigito.Text == "9" && txtSegundoDigito.Text == "9")
            {
                branco = branco + 1;
				audio();
				MessageBox.Show("FIM");
			}

			if (txtPrimeiroDigito.Text == "" && txtSegundoDigito.Text == "") 
			{
				MessageBox.Show("É necessário que você escolha um candidado(a) para votação.");
			}

			txtPrimeiroDigito.Text = "";
			txtSegundoDigito.Text = "";

			txtNome.Text = "";
			txtPartido.Text = "";

			picFoto.Hide();
		}

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtPrimeiroDigito.Text = "9";
            txtSegundoDigito.Text = "9";

            txtNome.Text = "NULO";
            txtPartido.Text = "NULO";

            picFoto.Image = Properties.Resources.avatar;
            picFoto.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Galo cego:                          " +cinco+ "\nJá não tava muito bom:   " + seis + "\nFernando Haddad:            " + treze + "\nBolsonaro:                          " + dezessete + "\nMarina Silva:                      " + dezoito + "\nAécio Neves:                      " + quarentaecinco + "\n \nVotos em branco:              " + branco);
            Environment.Exit(1);
        }

		private void audio() 
		{
			SoundPlayer audio = new SoundPlayer(urnaEletrônica.Properties.Resources.barulho);
			audio.Play();
		}
    }
}
