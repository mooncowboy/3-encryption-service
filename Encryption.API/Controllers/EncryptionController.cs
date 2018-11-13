using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Encryption.Utilities;

namespace Encryption.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EncryptionController : ControllerBase
	{
		// POST api/encrypt
		[HttpPost()]
        [Route("Encrypt")]
		public ActionResult<string> Encrypt([FromBody] string value)
		{
			return Util.Encrypt(value);
		}

        // POST api/decrypt
		[HttpPost()]
        [Route("Decrypt")]
        public ActionResult<string> Decrypt([FromBody] string hash)
		{
			return Util.Decrypt(hash);
		}
	}
}
