using DemoDinner.Application.Common.Interfaces.Services;

namespace DemoDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
