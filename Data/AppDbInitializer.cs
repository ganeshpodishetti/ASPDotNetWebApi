using CRUDOperations.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(!context.users.Any())
                {
                    context.users.AddRange(new User()
                    {
                        Name = "Ganesh",
                        Age = 23,
                        Gender = "Male",
                        PhnNo = "999999999",
                        Country = "India"
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
