using Microsoft.AspNetCore.Authentication.JwtBearer;

public static class RegisterDependetServices
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        // Register dependencies
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer();

        builder.Services.AddAuthorization();

        return builder;
    }
}