
using PoorMethodSignatures;

var userService = new UserService();

var user = userService.Login("username", "password");
var anotherUser = userService.GetUser("username");