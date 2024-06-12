using System.ComponentModel.DataAnnotations;

namespace apiDolar.Models
{
    public class Exportacion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombreProducto { get; set; }
        public int precioActualDolar { get; set; }
        public int kilos { get; set; }
        public DateOnly? fechaRegistrada { get; set; }








    }
}
