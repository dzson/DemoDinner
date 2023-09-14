using DemoDinner.Application.Authentication.Commands.Register;
using DemoDinner.Application.Authentication.Common;
using DemoDinner.Application.Authentication.Queries.Login;
using DemoDinner.Contracts.Authentication;
using Mapster;

namespace DemoDinner.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
