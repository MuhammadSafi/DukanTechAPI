using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukanTech.Shared
{
    public class AbstractResponse
    {
        public bool Success { get; set; }

        public StatusCode ResponseStatusCode { get; set; }

        public Error Error { get; set; }
    }
}
