//using Microsoft.AspNetCore.Authentication;

namespace Account.Profile;

public class Endpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/account/profile");
        Permissions("Profile_Read", "Profile_Update"); //permission claims can be enforced
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        //var claims = User.Claims.ToArray();
        //var accessToken = await HttpContext.GetTokenAsync("access_token");
        await SendStringAsync("ok! you have permission to see this...");
    }
}