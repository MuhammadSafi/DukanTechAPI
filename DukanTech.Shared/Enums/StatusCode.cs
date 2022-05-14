using System;
using System.Collections.Generic;
using System.Text;

namespace DukanTech.Shared.Enums
{

	public enum StatusCode
	{
		UnknownError,
		Success,
		UnhandledException,
		ConfigurationError,
		UserUnauthorized,
		EisRequestFailed,
		InvalidRequestParameterValue,
		UserNotFound,
		Created,
		Updated,
		Deleted,
		ProductNotFound
	}
}
