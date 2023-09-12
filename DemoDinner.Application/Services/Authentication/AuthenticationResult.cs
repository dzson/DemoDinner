using DemoDinner.Domain.Entities;

namespace DemoDinner.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);