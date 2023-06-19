namespace JWTAuth.WebApi.Models
{
    //https://www.c-sharpcorner.com/article/how-to-implement-jwt-authentication-in-web-api-using-net-6-0-asp-net-core/
    //pass= $admin@2022
    //email = admin@abc.com

    //oauth
    //https://github.com/titarenko/OAuth2

    //https://github.com/MrFrank75/ProtectedWebApi
    //https://www.dntips.ir/post/2906/%D8%A7%D9%85%D9%86-%D8%B3%D8%A7%D8%B2%DB%8C-%D8%A8%D8%B1%D9%86%D8%A7%D9%85%D9%87%E2%80%8C%D9%87%D8%A7%DB%8C-asp-net-core-%D8%AA%D9%88%D8%B3%D8%B7-identityserver-4x-%D9%82%D8%B3%D9%85%D8%AA-%DA%86%D9%87%D8%A7%D8%B1%D9%85-%D9%86%D8%B5%D8%A8-%D9%88-%D8%B1%D8%A7%D9%87-%D8%A7%D9%86%D8%AF%D8%A7%D8%B2%DB%8C-identityserver
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
