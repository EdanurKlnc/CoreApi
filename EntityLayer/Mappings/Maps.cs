using AutoMapper;
using EntityLayer.Models;
using EntityLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Student, StudentVM>().ReverseMap();
        }
    }
}
