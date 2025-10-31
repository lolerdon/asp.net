using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wordle.Models;

namespace Wordle.Data
{
    public class WordleContext : DbContext
    {
        public WordleContext (DbContextOptions<WordleContext> options)
            : base(options)
        {
            
        }

        public DbSet<Wordle.Models.Words> Words { get; set; } = default!;

        public static List<string> GetWordsByLength(int length)
        {
            List<string> words = ["apple", "grape", "mango", "peach", "berry", "lemon", "melon", "cherry", "plum", "kiwi"];
            return words.Where(w => w.Length == length).ToList();
        }
    }
}
