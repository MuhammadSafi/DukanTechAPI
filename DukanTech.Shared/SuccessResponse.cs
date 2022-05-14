using DukanTech.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukanTech.Shared
{
	public class SuccessResponse : AbstractResponse
	{
		public SuccessResponse()
		{
			Success = true;
			ResponseStatusCode = StatusCode.Success;
		}

		public SuccessResponse(StatusCode errorCode)
		{
			Error = new Error(errorCode);
		}

		public SuccessResponse(string errorMessage)
		{
			Error = new Error(errorMessage);
		}

		public SuccessResponse(Error error)
		{
			Error = error;
		}

		public SuccessResponse(Exception ex)
		{
			Error = new Error(StatusCode.UnhandledException, ex);
		}

		public SuccessResponse(StatusCode errorCode, Exception ex)
		{
			Error = new Error(errorCode, ex);
		}
	}
}
