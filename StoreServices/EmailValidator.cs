using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StoreServices
{
	public class EmailValidator:IEmailValidator
	{
		public bool ValidateAddress(string emailAddress)
		{
			Console.WriteLine("Validating: {0}", emailAddress);

			string pattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@(([0-9a-zA-Z])+([-\w]*[0-9a-zA-Z])*\.)+[a-zA-Z]{2,9})$";
			return Regex.IsMatch(emailAddress, pattern);
		}
	}
}
