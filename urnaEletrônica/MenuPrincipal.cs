using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urnaEletrônica
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			btn1 Form1 = new btn1();
			Form1.Show();
			this.Hide();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}
	}
}
