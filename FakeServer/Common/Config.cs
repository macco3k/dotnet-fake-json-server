namespace FakeServer.Common;

public class Config
{
    public string ApiRoute { get; set; } = "api";
    public string AsyncRoute { get; set; } = "async";
    public  string GraphQLRoute { get; set; } = "graphql";
    public  string TokenRoute { get; set; } = "token";
    public  string TokenLogoutRoute { get; set; } = "logout";
}