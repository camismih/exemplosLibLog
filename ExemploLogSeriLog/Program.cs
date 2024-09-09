using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Json;

Log.Logger = new LoggerConfiguration()
          .Enrich.FromLogContext()
          .WriteTo.Console(new JsonFormatter())
          .CreateLogger();

var factory = LoggerFactory.Create(builder =>
{
    builder.AddSerilog(dispose: true);
});

var logger = factory.CreateLogger<Program>();

var department = new Department("IT");
var owner = new Owner("Camila", department);
var todo = new Todo("Fazer as POCs", owner);

logger.LogInformation("Todo created at {timestamp} {@todo}",  DateTime.UtcNow, todo);

record class Todo(string Title, Owner owner, bool Done = false);

record class Owner(string name, Department department);

record class Department(string Name);