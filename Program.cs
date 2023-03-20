var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/Hello", (string name) => $"Hola {name}");
app.MapGet("/Hellowithname/{name}/{lastName}", 
    (String name, String lastName) =>"$Hola {name} {lastName}");
app.MapGet("/response", async () => 
    {
          HttpClient client = new HttpClient();
        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;


    });





app.Run();
