var builder = DistributedApplication.CreateBuilder(args);

var console = builder.AddProject<Projects.DemoAgain_Console>("console");

var postgres = builder.AddPostgres("postgres");

var database = postgres.AddDatabase("demodb");

console.WithReference(database);

builder.Build().Run();
