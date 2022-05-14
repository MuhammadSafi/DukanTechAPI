using DukanTech.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukanTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DukanTechControllerBase : ControllerBase
    {
        protected IActionResult GetActionResult(SuccessResponse response)
        {

            if (!response.Success)
            {
                switch (response.Error.Code)
                {
                    case DukanTech.Shared.Enums.StatusCode.UserUnauthorized:
                        return Forbid();
                    case DukanTech.Shared.Enums.StatusCode.UserNotFound:
                        return NotFound(response);
                    default:
                        return BadRequest(response);
                }
            }

            return Ok(response);
        }

        protected IActionResult GetActionResult(AbstractResponse response, object routeVaules = null, string MethodName = "Get")
        {
            if (response.Success)
            {
                switch (response.ResponseStatusCode)
                {
                    case DukanTech.Shared.Enums.StatusCode.Created:
                        return CreatedAtAction(MethodName, routeVaules, response);
                    case DukanTech.Shared.Enums.StatusCode.Updated:
                    case DukanTech.Shared.Enums.StatusCode.Deleted:
                        return Ok(response);
                    default:
                        return BadRequest(response);
                }
            }
            else
            {
                switch (response.ResponseStatusCode)
                {
                    case DukanTech.Shared.Enums.StatusCode.UserUnauthorized:
                        return Forbid();
                    case DukanTech.Shared.Enums.StatusCode.UserNotFound:
                        return NotFound(response);
                    default:
                        return BadRequest(response);
                }
            }
        }
    }
}
