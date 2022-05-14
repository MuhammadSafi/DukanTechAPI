using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukanTech.Shared
{
    public class PassedResponse : AbstractResponse
    {
        public PassedResponse()
        {
            Success = true;
            ResponseStatusCode = StatusCode.Success;
        }

        public PassedResponse(StatusCode statusCode)
        {
            Success = true;
            ResponseStatusCode = statusCode;
        }
    }
}
