using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroDetalle.Entidades
{
    public class Cotizaciones
    {
        [Key]

        public int CotizacionId { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(100)]
        public string Observaciones { get; set; }


        public virtual ICollection<DetalleCotizaciones> Detalle { get; set; }

        public Cotizaciones()
        {   
            this.Detalle = new List<DetalleCotizaciones>();
        }

        public void AgregarDetalle(int id, int CotizacionId, int PersonaId, int ArticuloId, float CantidadCotizada, float Precio, float Importe)
        {
            this.Detalle.Add(new DetalleCotizaciones(id, CotizacionId, PersonaId, ArticuloId, CantidadCotizada, Precio, Importe));
        }
    }
}
