namespace UserApi.Application.DTOs;

public record CreateUserRequest(
    string Name,
    string Email,
    string Cpf,
    string PhoneNumber
);