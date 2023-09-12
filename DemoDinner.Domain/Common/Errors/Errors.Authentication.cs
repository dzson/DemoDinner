﻿using ErrorOr;

namespace DemoDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(
            "Auth.InvalidCredentials",
            "Invalid credentials.");
    }
}
