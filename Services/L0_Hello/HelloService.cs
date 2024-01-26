namespace allforone.Services.L0_Hello;

public class HelloService : IHelloService
{
    public string Hello(string userName){
        if(!String.IsNullOrEmpty(userName)){
            return $"Hello, {userName}!";
        } else {
            return "Hello, User!";
        }
    }
}
