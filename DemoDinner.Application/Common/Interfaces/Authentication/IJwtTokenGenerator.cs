using DemoDinner.Domain.Entities;

namespace DemoDinner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
