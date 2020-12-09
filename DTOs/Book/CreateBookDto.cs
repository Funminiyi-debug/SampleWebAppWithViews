using SampleWebAppWithViews.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppWithViews.DTOs.Book
{
    public class CreateBookDto
    {
        //private string genre;

      //  List<string> genres = new List<string> { "romance", "thriller", "sci-fi", "comedy", "fantasy" };

        [StringLength(maximumLength: 20, ErrorMessage = "The Author characters should be between 2 and 20.", MinimumLength = 3)]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }

        [Required, EnumDataType(typeof(Genre))]
        public string Genre
        {
            get;set;
        }
    }
}
