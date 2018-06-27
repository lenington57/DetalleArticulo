using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RegistroDetalle.Entidades
{
    public class DetalleCotizaciones
    {
        [Key]
        public int Id { get; set; }

        public int CotizacionId { get; set; }

        public int PersonaId { get; set; }

        public int ArticulosId { get; set; }

        public float CantidadCotizada { get; set; }

        public float Precio { get; set; }

        public float Importe { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Personas { get; set; }

        [ForeignKey("ArticulosId")]
        public virtual Articulos Articulos { get; set; }
        

        public DetalleCotizaciones()
        {
            this.Id = 0;
            this.CotizacionId = 0;
            this.PersonaId = 0;
            this.ArticulosId = 0;
            this.CantidadCotizada = 0;
            this.Precio = 0;
            this.Importe = 0;
        }

        public DetalleCotizaciones(int id, int cotizacionId, int personaId, int articulosId, float cantidadCotizada, float precio, float importe)
        {
            Id = id;
            CotizacionId = cotizacionId;
            PersonaId = personaId;
            ArticulosId = articulosId;
            CantidadCotizada = cantidadCotizada;
            Precio = precio;
            Importe = importe;
        }
        
        public override string ToString()
        {
            return "Articulos: " + this.ArticulosId.ToString() + ":CantidadCotizada " + this.CantidadCotizada;
        }
    }
}
