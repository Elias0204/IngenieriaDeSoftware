using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIngenieriaDeSoftware.BLL;

namespace ProyectoIngenieriaDeSoftware.PL
{
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion();
        }

        private void RecuperarInformacion()
        {
            DepartamentoBLL oDepartamento = new DepartamentoBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamento.ID = ID;

            oDepartamento.Departamento = txtDepartamento.Text;

            MessageBox.Show(oDepartamento.ID.ToString());
            MessageBox.Show(oDepartamento.Departamento);
        }
    }
}
