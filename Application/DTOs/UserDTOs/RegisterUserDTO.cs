namespace Application.DTOs.UserDTOs;

public class RegisterUserDTO
{
    public string UserName { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public long MobileNo { get; set; }
}