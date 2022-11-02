public static class SetupMiddlewarePipeline
{
    public static WebApplication SetupMiddleware(this WebApplication app)
    {
        // Configure the pipeline

        app.UseAuthentication();
        app.UseAuthorization();

        //app.MapGet("/", [Authorize] () =>
        //{
        //    return "test";
        //}); 

        //or

        app.MapGet("/", () =>
        {
            return "test";
        }).RequireAuthorization();
        
        return app;
    }
}
