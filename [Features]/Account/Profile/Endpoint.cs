//using Microsoft.AspNetCore.Authentication;

namespace Account.Profile;

public class Endpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/account/profile");
        PermissionsAll("Profile_Read", "Profile_Update");
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        //var claims = User.Claims.ToArray();
        //var accessToken = await HttpContext.GetTokenAsync("access_token");
        await SendStringAsync("ok! you have permission to see this...");
    }
}

