using AutoMapper;
using SampleWebAppWithViews.DTOs.Book;
using SampleWebAppWithViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppWithViews.Data
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<CreateBookDto, Book>();
            CreateMap<Book, ReadBookDto>().ReverseMap();
        }


    }
}
