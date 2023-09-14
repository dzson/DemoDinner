using DemoDinner.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace DemoDinner.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
