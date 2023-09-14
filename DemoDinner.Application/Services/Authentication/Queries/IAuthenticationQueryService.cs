using DemoDinner.Application.Services.Authentication.Common;
using ErrorOr;

namespace DemoDinner.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
}
