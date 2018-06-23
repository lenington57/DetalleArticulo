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
        public float Cantidad { get; set; }
        public float Precio { get; set; }
        public float Importe { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Personas { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulos { get; set; }
        

        public DetalleCotizaciones()
        {
            this.Id = 0;
            this.CotizacionId = 0;
        }

        public DetalleCotizaciones(int id, int cotizacioId, int personaId, int articulosId, float cantidad, float precio, float importe)
        {
            Id = id;
            CotizacionId = cotizacioId;
            PersonaId = personaId;
            ArticulosId = articulosId;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
