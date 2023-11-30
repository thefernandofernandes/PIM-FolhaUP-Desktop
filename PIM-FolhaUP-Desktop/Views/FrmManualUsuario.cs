using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_FolhaUP_Desktop.Views
{
    public partial class FrmManualUsuario : Form
    {
        public FrmManualUsuario()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = new DialogResult();
            dialogo = MessageBox.Show("Quer mesmo sair do FolhaUp?", "Alerta!", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
