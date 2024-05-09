using System.ComponentModel.DataAnnotations;

namespace BASE_API.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; } // ID de 9 dígitos numérico
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientEmail { get; set; }
        public long ClientCellPhone { get; set; } // Número de teléfono celular de 8 dígitos
        public string ClientAddress { get; set; }
        [RegularExpression("[AI]")]
        public string ClientState { get; set; }
    }
}
