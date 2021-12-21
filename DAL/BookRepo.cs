using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookRepo
    {
        static LibaryesEntities db;

        static BookRepo()
        {
            db = new LibaryesEntities();
        }

        public static List<Book>GetAll()
        {
            return db.Books.ToList();
        }

        public static Book Get(int id)

        {
            return db.Books.FirstOrDefault(e => e.Id == id);


        }

        public static void Edit(Book b)
        {
            var data = db.Books.FirstOrDefault(e => e.Id == b.Id);
            db.Entry(data).CurrentValues.SetValues(b);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            var data = db.Books.FirstOrDefault(e => e.Id == id);
            db.Books.Remove(data);
            db.SaveChanges();

        }
    }
}
