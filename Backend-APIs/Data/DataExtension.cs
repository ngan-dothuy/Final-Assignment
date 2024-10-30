using System;
using Microsoft.EntityFrameworkCore;

namespace Backend_APIs.Data;

public static class DataExtension
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ProjectContext>();
        dbContext.Database.Migrate();
    }


}