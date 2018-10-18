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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            // Creamos la conexión.
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                           integrated security = true; database = AdventureWorks2014;");

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
                    lbListar.Items.Add(rdr[0]);
                    lbListar.Items.Add(rdr[1]);

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
