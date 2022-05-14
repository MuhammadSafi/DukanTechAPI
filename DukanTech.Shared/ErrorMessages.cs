using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukanTech.Shared
{
    public static class ErrorMessages
    {
        private static readonly Dictionary<StatusCode, string> _errors = new Dictionary<StatusCode, string>
        {
            [StatusCode.UnknownError] = null,
            [StatusCode.UnhandledException] = "The service encountered an unhandled exception",
            [StatusCode.ConfigurationError] = "Error in service configuration",
            [StatusCode.UserUnauthorized] = "The user is not authorized to perform this operation",
            [StatusCode.UserNotFound] = "The requested user cannot be found",
            [StatusCode.EisRequestFailed] = "A request to another service failed",
            [StatusCode.InvalidRequestParameterValue] = "Invalid parameter value was provided in the request",

        };

        public static string Get(StatusCode code) => _errors[code];
    }
}
