using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrendlogVisualization.Models;

namespace TrendlogVisualization.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TrendlogContext(serviceProvider.GetRequiredService<DbContextOptions<TrendlogContext>>()))
            {
                if (context.SuperData.Any())
                {
                    return;
                }

                context.SuperData.AddRange(
                    new SuperDataClass
                    {
                        TotalOrders = 25621,
                        ClientProfits = 123,
                        PeopleInterested = 2,
                        ProductPrice = 12365,
                    }
                    );

                context.SuperData.AddRange(
                    new SuperDataClass
                    {
                        TotalOrders = 50,
                        ClientProfits = 235,
                        PeopleInterested = 35,
                        ProductPrice = 954636,
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
