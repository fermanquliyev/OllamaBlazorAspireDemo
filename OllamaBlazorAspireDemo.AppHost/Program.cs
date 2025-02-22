var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
                .WithDataVolume()
                 .WithLifetime(ContainerLifetime.Persistent);

var ollamablazoraspiredemodb = sql.AddDatabase("ollamablazoraspiredemodb");


var ollama =
    builder.AddOllama("ollama") //Add Ollama container to the app host
        .WithDataVolume() //Adds a data volume to store models
        .WithGPUSupport() // Use your beefy GPU 
        .WithLifetime(ContainerLifetime.Persistent); //  Keep the container running
                                                     //    when the app exits

// Add DeepSeek-R1 7B model to Ollama server
var chatmodel =
    ollama.AddModel("chatmodel", "deepseek-r1:7b");

var chatmodelendpoint = ollama.GetEndpoint("chatmodelendpoint");


builder.AddProject<Projects.OllamaBlazorAspireDemo>("ollamablazoraspiredemo")
    .WithReference(ollamablazoraspiredemodb)
       .WaitFor(ollamablazoraspiredemodb)
    .WithReference(chatmodel)
           .WaitFor(chatmodel)
           .WithReference(chatmodelendpoint);

builder.Build().Run();
