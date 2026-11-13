namespace Cars.API.Dtos
{
    public record ResetPasswordDto(
        string Email,
        string Token,
        string NewPassword);
}
