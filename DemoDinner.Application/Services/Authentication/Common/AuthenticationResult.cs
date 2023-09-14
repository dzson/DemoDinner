using DemoDinner.Domain.Entities;

namespace DemoDinner.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);