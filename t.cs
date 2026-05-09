using System.Runtime.InteropServices;

Console.WriteLine("1");

try
{
    Console.WriteLine("2");

    Console.WriteLine(RuntimeInformation.OSDescription);

    Console.WriteLine("3");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("4");



var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Map("/", (HttpContext context) =>
{
    return context.Request.Path + context.Request.QueryString.Value + ">" + string.Join("; ", context.Request.Headers.Select(p => $"{p.Key}: {p.Value}"));
});

app.Run();
