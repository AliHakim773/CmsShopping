using CmsShopping.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CmsShopping.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using ( var context = new CmsShoppingContext
              (serviceProvider.GetRequiredService<DbContextOptions<CmsShoppingContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }

                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Content = "Home Page",
                        Sorting = 0,
                    },
                    new Page
                    {
                        Title = "About us",
                        Slug = "about-us",
                        Content = "About us Page",
                        Sorting = 100,
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "Services Page",
                        Sorting = 100,
                    },
                    new Page
                    {
                        Title = "Contact",
                        Slug = "contact",
                        Content = "Contact Page",
                        Sorting = 100,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
