var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres");

var database = postgres.AddDatabase("appdb");

builder.AddProject<Projects.ConsolePostgresDemo_Console>("console")
	.WithReference(database);

builder.Build().Run();
