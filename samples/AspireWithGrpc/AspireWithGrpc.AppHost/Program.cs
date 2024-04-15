var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireWithGrpc_ApiService>("apiservice");

builder.AddProject<Projects.AspireWithGrpc_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
