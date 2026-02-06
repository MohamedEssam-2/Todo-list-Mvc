using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business_Logic_Layer.DTO;
using Data_Access_Layer.Models;

namespace Business_Logic_Layer.Profiles
{
    public class MappingProfile:Profile

    {
        public MappingProfile()
        {
            CreateMap<AddOrUpdateTodoDto, Todo>().ReverseMap();
            CreateMap<TodoDto, Todo>().ReverseMap();

        }
    }
}
