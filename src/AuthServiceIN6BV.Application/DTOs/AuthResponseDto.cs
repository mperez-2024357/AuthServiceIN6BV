namespace AuthServiceIN6BV.Application.DTOs;
public class AuthResponseDto
{
    public bool Sucees {get;set;}=true;
    public string Message {get;set;}= string.Empty;
    public string Token {get;set;}= string.Empty;

    public UserDetailsDto UserDetailsDto {get;set;}= new();
    public DateTime ExpiresAt {get; set;}
}