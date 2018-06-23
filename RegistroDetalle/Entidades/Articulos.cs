using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDetalle.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticulosId { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public float Existencia { get; set; }

        public float CantCotizada { get; set; }


        public Articulos()
        {
            ArticulosId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            CantCotizada = 0;
        }
    }
}
