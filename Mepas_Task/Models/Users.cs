namespace Mepas_Task.Models
{
    public class Users : BaseClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool Status { get; set; }
    }
}
