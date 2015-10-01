using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StoreServices
{
	[ServiceContract]
	public interface IEmailValidator
	{
		[OperationContract]
		bool ValidateAddress(string emailAddress);
	}
}
