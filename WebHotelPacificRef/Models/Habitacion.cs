using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHotelPacificRef.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        [Key]
        [Column("habitacion_id")]
        public int Id { get; set; }

        [Column("hotel_id")]
        public int HotelId { get; set; }

        [Column("Numero")]
        public int Numero { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("capacidad")]
        public int Capacidad { get; set; }

        [Column("precio")]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal Precio { get; set; }

        [Column("estado")]
        public int Estado { get; set; }
    }
}
