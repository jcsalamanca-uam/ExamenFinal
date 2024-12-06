using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenFinal.Class;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        ProductoDAO productoDAO = new ProductoDAO();

        public Form1()
        {
            InitializeComponent();
            MostrarProductos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TbID.Text);
                string nombre = TbNombre.Text;
                decimal precio = decimal.Parse(TbPrecio.Text);
                int cantidad = int.Parse(TbCantidad.Text);

                Producto producto = new Producto(id, nombre, precio, cantidad);
                productoDAO.Actualizar(producto);
                MostrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int id = int.Parse(TbID.Text);
                    string nombre = TbNombre.Text;
                    decimal precio = decimal.Parse(TbPrecio.Text);
                    int cantidad = int.Parse(TbCantidad.Text);

                    Producto producto = new Producto(id, nombre, precio, cantidad);
                    productoDAO.Agregar(producto);
                    MostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TbEliminarID.Text);

                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    productoDAO.Eliminar(id);
                    MostrarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarProductos()
        {
            DGVReporte_.DataSource = null;
            DGVReporte_.DataSource = productoDAO.ObtenerTodos();
        }
    }
}
