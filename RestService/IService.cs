using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestService
{
	[ServiceContract]
	public interface IService
	{
		[OperationContract]
		[WebGet(UriTemplate = "Authenticate?username={username}&password={password}")]
		Stream Authenticate(string username, string password);

		[OperationContract]
		[WebGet(UriTemplate = "Register?username={username}&password={password}&identification={identification}")]
		Stream Register(string username, string password, string identification);
	}
}
