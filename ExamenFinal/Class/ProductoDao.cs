using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductoDAO
    {
        private List<Producto> productos = new List<Producto>();

        public void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return productos;
        }

        public void Actualizar(Producto producto)
        {
            var p = productos.FirstOrDefault(pr => pr.Id == producto.Id);
            if (p != null)
            {
                p.Nombre = producto.Nombre;
                p.Precio = producto.Precio;
                p.Cantidad = producto.Cantidad;
            }
        }

        public void Eliminar(int id)
        {
            var p = productos.FirstOrDefault(pr => pr.Id == id);
            if (p != null)
            {
                productos.Remove(p);
            }
        }
    }

}
