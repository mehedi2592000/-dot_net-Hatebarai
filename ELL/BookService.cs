using AutoMapper;
using DAL;
using ELL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELL
{
    public class BookService
    {
        public static List<BookModel>GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BookModel>>(BookRepo.GetAll());

            return data;
        }

    }
}
