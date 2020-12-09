using SampleWebAppWithViews.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppWithViews.Models
{
    public class Book
    {
        //private string genre;

        //List<string> genres = new List<string> { "romance", "thriller", "sci-fi", "comedy", "fantasy" };
        [Key]
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Genre Genre { get; set; }
        //public string Genre
        //{
        //    get
        //    {
        //        return genre;
        //    }
        //    set
        //    {
        //        if (genres.Any(g => g.Equals(value, StringComparison.OrdinalIgnoreCase)))
        //        {
        //            genre = value;
        //        }
        //    }
        //}

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
