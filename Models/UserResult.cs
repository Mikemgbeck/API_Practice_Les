namespace Commander.Models
{
    public class UserResult
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public bool Successful { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
    }
}