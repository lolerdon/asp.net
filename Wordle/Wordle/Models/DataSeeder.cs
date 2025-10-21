using Microsoft.EntityFrameworkCore;
using Wordle.Data;

namespace Wordle.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WordleContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<WordleContext>>()))
            {
                // Look for any movies.
                if (context.Words.Any())
                {
                    return;   // DB has been seeded
                }

                context.Words.AddRange(
                    new Words
                    {
                        Letters = "apple",
                        Lenght = "5",
                        CreatedAt = DateTime.Now
                    },
                    new Words
                    {
                        Letters = "grape",
                        Lenght = "5",
                        CreatedAt = DateTime.Now
                    },
                    new Words
                    {
                        Letters = "peach",
                        Lenght = "5",
                        CreatedAt = DateTime.Now
                    },
                    new Words
                    {
                        Letters = "mango",
                        Lenght = "5",
                        CreatedAt = DateTime.Now
                    },
                    new Words
                    {
                        Letters = "berry",
                        Lenght = "5",
                        CreatedAt = DateTime.Now
                    }
                );
                context.SaveChanges();
            }
        }
    }
}