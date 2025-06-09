using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Models;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesAppContext>>()))
            {
                // Проверяем, есть ли уже данные в базе
                if (context.Movie.Any())
                {
                    return; // База уже содержит данные
                }

                // Добавляем начальные данные
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Когда Гарри встретил Салли",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Романтическая комедия",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Охотники за привидениями",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Комедия",
                        Price = 8.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Охотники за привидениями 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Комедия",
                        Price = 9.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Рио Браво",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Вестерн",
                        Price = 3.99M,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}