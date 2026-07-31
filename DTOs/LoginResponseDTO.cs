namespace LRMS_API.DTOs;

public class LoginResponseDTO
{
    public int LoginId { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;
}