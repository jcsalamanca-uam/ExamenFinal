﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Class
{
    public class Producto
    {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto(int id, string nombre, decimal precio, int cantidad)
            {
                Id = id;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
        }

    }


