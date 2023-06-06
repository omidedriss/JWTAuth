namespace JWTAuth.WebApi.Models
{
    //https://www.c-sharpcorner.com/article/how-to-implement-jwt-authentication-in-web-api-using-net-6-0-asp-net-core/
    //pass= $admin@2022
    //email = admin@abc.com
    public class UserInfo
    {
        public int UserId { get; set; }
        public string? DisplayName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
