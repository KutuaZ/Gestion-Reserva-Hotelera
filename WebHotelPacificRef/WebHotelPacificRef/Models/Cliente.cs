using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHotelPacificRef.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("cliente_id")]
        public int Id { get; set; }

        [Column("rut")]
        public string Rut { get; set; } = string.Empty;

        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("apellido")]
        public string Apellido { get; set; } = string.Empty;

        [Column("correo_electronico")]
        public string Correo { get; set; } = string.Empty;

        [Column("telefono")]
        public string Telefono { get; set; } = string.Empty;
    }
}