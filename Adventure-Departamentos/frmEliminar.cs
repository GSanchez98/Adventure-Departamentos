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
    public partial class frmEliminar : Form
    {
        //creando la conexion, antes de todo porque cargare los datos desde el load
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                           integrated security = true; database = AdventureWorks2014;");

        public frmEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // creamos el comando para ejecutar el StoreProcedure.
            SqlCommand cmd = new SqlCommand("sp_EliminarDepartamento", conn);

            // especificamos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // especificamos los parametros del procemiento almacenado.
                cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.SmallInt));
                cmd.Parameters["@Codigo"].Value = lbEliminar.SelectedItem.ToString();

                // abrimos las conexión.
                conn.Open();

                // Eliminamos el departamento.

                if (lbEliminar.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor debe seleccionar un departamento", "Error en ingreso", MessageBoxButtons.OK);
                }
                else
                {
                    // ejecutamos el comando
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Departamento eliminado correctamente", "Control de departamentos", MessageBoxButtons.OK);
                    lbEliminar.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la exepción");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Recargue el valor de los departamentos" + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // cerramos la conexión.
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            // Creamos el query de selección de la tabla departamontos
            string sql1 = "Select DepartmentID,Name FROM HumanResources.Department";

            // Creamos el comando
            SqlCommand cmd = new SqlCommand(sql1, conn);

            // establecemos la conexión y llenado el dataGridView
            try
            {
                // abrimos la conexión.
                conn.Open();

                // Ejecutamos el query via un DataReader y llenamo el Grid.
                SqlDataReader rdr = cmd.ExecuteReader();

                // llenamos el DataGrid
                while (rdr.Read())
                {
                    lbEliminar.Items.Add(rdr[0]);
                    lbEliminar.Items.Add(rdr[1]);

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");

            }
            finally
            {
                // Cerramos la conexión.
                conn.Close();
            }
        }
    }
}
