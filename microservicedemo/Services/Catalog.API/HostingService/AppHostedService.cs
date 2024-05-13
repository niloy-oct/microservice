﻿using Catalog.API.DatabaseContext;

namespace Catalog.API.HostingService;

public class AppHostedService : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        CatalogDbContextSeed.Seed();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
       return Task.CompletedTask;
    }
}