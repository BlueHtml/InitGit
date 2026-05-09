
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Map("/", (HttpContext context) =>
{
    return context.Request.Path + context.Request.QueryString.Value + ">" + string.Join("; ", context.Request.Headers.Select(p => $"{p.Key}: {p.Value}"));
});

app.Run();
