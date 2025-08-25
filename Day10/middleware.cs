// In Startup.cs
void Configure(IApplicationBuilder app)
{
    app.Use(async (context, next) =>
    {
        Console.WriteLine("Middleware executing...");
        await next.Invoke();
    });
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Hello from middleware!");
    });
}
