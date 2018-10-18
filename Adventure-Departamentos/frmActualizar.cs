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
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que el codigo haya sido ingresaado para realizar la actualización.
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar el codigo del departamento", "Error en ingreso", MessageBoxButtons.OK);

            }
            else
            {
                // Creamos la conexión
                SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                     integrated security = true; database = AdventureWorks2014;");
                // Creamos el comando
                SqlCommand cmd = new SqlCommand("sp_EditarDepartamento", conn);

                // especificamos el tipo de comando
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Definimos los parámetros del StoreProcedure.

                    cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.SmallInt, 10));
                    cmd.Parameters["@Codigo"].Value = txtCodigo.Text;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombre.Text;

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Descripcion"].Value = txtDescripción.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaM", SqlDbType.DateTime));
                    cmd.Parameters["@FechaM"].Value = System.DateTime.MaxValue;


                    // Abrimos la conexión.
                    conn.Open();

                    // Ejecutamos el comando
                    cmd.ExecuteNonQuery();

                    // Mostramos un  mensaje de confirmación.
                    MessageBox.Show("Departamento actualizado correctamente", "Control de departamentos", MessageBoxButtons.OK);
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtDescripción.Text = "";
                    dtpFecha.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");
                    throw;
                }
                finally
                {
                    // Cerramos la conexión.
                    conn.Close();
                }
            }
        }
    }
