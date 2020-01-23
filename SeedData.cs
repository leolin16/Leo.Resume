using System;
using System.Collections.Generic;
using Leo.ResumeProfile.Data;
using Leo.ResumeProfile.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Leo.ResumeProfile
{
    public static class SeedData
    {
        public static IHost EnsureSeedDataForResume(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
                    context.Database.EnsureDeletedAsync();
                    context.Database.MigrateAsync();
                }
                catch (Exception ex)
                {
                    
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating the database.");
                }
                

                // applicationDbContext.Database.EnsureDeletedAsync();
                // applicationDbContext.Database.MigrateAsync();
                // applicationDbContext.Database.EnsureCreatedAsync();

                // var screens = new List<Screen>(){
                //     new Screen { Category= "Others", ScreenName="EP_LOGIN", ScreenJpName="ログイン_EP"},
                //     new Screen { Category= "Eface_Core", ScreenName="EC_CHANGE_ACTOR_MF", ScreenJpName= "担当者変更_MainFrame"},
                //     new Screen { Category= "Create_Quick", ScreenName="EP_CREATE_APP_QUICK", ScreenJpName= "クイック申込"}
                // };

                // applicationDbContext.Screens.AddRangeAsync(screens);

                // applicationDbContext.SaveChangesAsync();
                // Console.WriteLine("Screens added");
            }
            return host;
        }
    }
}