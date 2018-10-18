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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Creamos la conexión.
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                           integrated security = true; database = AdventureWorks2014;");


            // Creamos el comando sql
            SqlCommand cmd = new SqlCommand("sp_RegistrarDepartamento", conn);

            // Establecemos el comando como un storeProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                // defiinimos los parametros del store Procedure
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Nombre"].Value = txtNombre.Text;

                cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Descripcion"].Value = txtDescripción.Text;

                cmd.Parameters.Add(new SqlParameter("@FechaM", SqlDbType.DateTime));
                cmd.Parameters["@FechaM"].Value = System.DateTime.Now;

                // Abrimos la conexión
                conn.Open();

                // ejecutamos el query
                cmd.ExecuteNonQuery();

                //Mostramos un mensaje de confirmación.
                MessageBox.Show("Departamento registrado satifactoriamente", "Control de departamentos", MessageBoxButtons.OK);

                // Limpiamos los Textbox
                txtDescripción.Text = "";
                txtNombre.Text = "";
                txtNombre.Focus();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");
            }
            finally
            {
                // Cerramos la conexión
                conn.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
