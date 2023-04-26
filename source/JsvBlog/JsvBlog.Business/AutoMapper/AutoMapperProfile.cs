using AutoMapper;
using JsvBlog.Business.Entities;
using JsvBlog.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Business.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
        }
    }
}
