function UserAccountController()
{
	var api = this;
	var _BASEURL = "http://localhost:1466";

	api.Authenticate = function (user, fn_callback)
	{
		$.get(_BASEURL+"/MyService.svc/Authenticate?username=" + user.username + "&password=" + user.password, function (data) {
			if(typeof fn_callback == "function")
			{
				fn_callback(data);
			}
			else {
				alert(data);
			}
		});
	}
	api.Register = function (account, fn_callback)
	{
		$.get(_BASEURL+"/MyService.svc/Register?username=" + account.username + "&password=" + account.password+"&identification=" + account.identification, function (data) {
			if(typeof fn_callback == "function")
			{
				fn_callback(data);
			}
			else {
				alert(data);
			}
		});
	}
}