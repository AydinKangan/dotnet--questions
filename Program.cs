var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", context =>
{
    string information = Information.ReturnInformation();
    return context.Response.WriteAsync(information);
});


app.MapPost("/add/{question}/{answer}", (string question, string answer) =>
{
    QuestionAnswer addQuestion = Add.AddQuestion(question, answer);
});

app.Run();

