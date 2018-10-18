using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Adventure_Departamentos
{
    public partial class FrmOperacionesCRUD : Form
    {
        // crearemos la conexion
        SqlConnection conn = new SqlConnection(@" server = (local)\ sqlexpress; integrado security = true; database = AdventureWorks2014; ");

        public FrmOperacionesCRUD()
        {
            InitializeComponent();
        }

        private void FrmOperacionesCRUD_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // hacemos el llamado al formulario correspondiente a Agregar
            frmAgregar a = new frmAgregar();
            a.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // hacemos el llamado al formulario correspondiente a Eliminar
            frmEliminar el = new frmEliminar();
            el.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // hacemos el llamado al formulario correspondiente a Eliminar
             frmListar l = new frmListar();
            l.Show();
        }
    }
}
