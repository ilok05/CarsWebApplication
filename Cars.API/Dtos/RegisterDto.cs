namespace Cars.API.Dtos
{
    public record RegisterDto(
        string UserName, 
        string Email, 
        string Password);
}
