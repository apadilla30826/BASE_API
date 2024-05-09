namespace BASE_API.Models.DTO
{
    public class ClientDTO
    {
        public int ClientId { get; set; } 
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientEmail { get; set; }
        public long ClientCellPhone { get; set; }
        public string ClientAddress { get; set; }
        public string ClientState { get; set; }
    }
}
