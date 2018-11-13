using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Encryption.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EncryptionController : ControllerBase
	{
		// POST api/encrypt
		[HttpPost()]
		public ActionResult<string> Encrypt([FromBody] string value)
		{
			return "encrypted...";
		}

        // POST api/decrypt
		[HttpPost()]
		public ActionResult<string> Encrypt([FromBody] string value)
		{
			return "decrypted...";
		}
	}
}
