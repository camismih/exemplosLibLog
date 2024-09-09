using Microsoft.Extensions.Logging;

var factory = LoggerFactory.Create(builder =>
{
builder.AddJsonConsole();
});

var logger = factory.CreateLogger<Program>();

var department = new Department("IT");
var owner = new Owner("Camila", department);
var todo = new Todo("Fazer as POCs", owner);

logger.LogTodo(DateTime.UtcNow, todo);

record class Todo(string Title, Owner owner, bool Done = false);

record class  Owner(string name, Department department);

record class Department(string Name);

static partial class LogMessages
{
 [LoggerMessage(
    Level =LogLevel.Information,
    Message ="Todo created at {timestamp}"
 )]
#pragma warning disable EXTEXP0003 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
    public static partial void LogTodo(this ILogger logger, DateTime timestamp, [LogProperties(OmitReferenceName = true, Transitive = true)] Todo todo);
#pragma warning restore EXTEXP0003 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
}