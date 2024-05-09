namespace BASE_API.Models.DTO
{
    public class ResponseDTO
    {
        public bool Succed { get; set; }
        public object Result { get; set; }
        public string DisplayMessage { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
