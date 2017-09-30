function Main() {
	var idLoginUsername = $('#idLoginUsername');
	var idLoginPassword = $('#idLoginPassword');
	var idLoginSubmitButton = $('#idLoginSubmitButton');
	var idRegisterButton = $('#idRegisterButton');

	var controller = new UserAccountController();

	idLoginSubmitButton.click(function () {
		var user = {
			username: idLoginUsername.val(),
			password: idLoginPassword.val()
		};
		controller.authenticate(user)
	});
	idRegisterButton.click(function () {
		var account = {
			username: idLoginUsername.val(),
			password: idLoginPassword.val(),
			identification:null
		};
		controller.Register(account, function (data) {
			alert(data);
		});
	});

};
$(document).ready(function () {
	Main();
});