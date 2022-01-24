using AutoMapper;
using MyAPIProject.Data.Data;
using MyAPIProject.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPIProject.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BooksVM>().ReverseMap();
        }
    }
}
