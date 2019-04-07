namespace SOLUTIONS.GALAXY.Infraestructure.Domain.Entities
{
    public class Message
    {
        public bool IsError { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string TechnicalMessage { get; set; }
    }
}
