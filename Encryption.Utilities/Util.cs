using System;

namespace Encryption.Utilities
{
	public class Util
	{
		public static string Encrypt(string input)
		{
			return "encrypted-" + input;
		}

		public static string Decrypt(string hash)
		{
			return hash.Replace("encrypted-", "");
		}
	}
}
