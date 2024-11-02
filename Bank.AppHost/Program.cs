var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ApiGateway>("apigateway");

builder.AddProject<Projects.BankAccountService_Api>("bankaccountservice-api");

builder.Build().Run();
