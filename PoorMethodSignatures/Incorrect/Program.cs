
using PoorMethodSignatures;

var userService = new UserService();

var user = userService.GetUser("username", "password", true);
var anotherUser = userService.GetUser("username", null, false);