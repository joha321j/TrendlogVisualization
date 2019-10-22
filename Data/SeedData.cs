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

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Muslim Al-Ali",
                        JobTitle = "Muslim",
                        SaleValue = 987,
                        PicturePath = "./assets/images/avatars/3.jpg"
                    }
                    );

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Kaare Væggerby Sandbøl",
                        JobTitle = "Pikspiller",
                        SaleValue = 1234,
                        PicturePath = "./assets/images/avatars/4.jpg"
                    }
                    );

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Anders Fredensborg Rasmussen",
                        JobTitle = "Håndværker",
                        SaleValue = 2,
                        PicturePath = "./assets/images/avatars/1.jpg"
                    }
                    );

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Kasper Malsmiö Hoffmann",
                        JobTitle = "Nørd",
                        SaleValue = 6457,
                        PicturePath = "./assets/images/avatars/8.jpg"
                    }
                    );

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "Johannes Ehlers Nyholm Thomsen",
                        JobTitle = "Wanker",
                        SaleValue = -5,
                        PicturePath = "./assets/images/avatars/3.jpg"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
