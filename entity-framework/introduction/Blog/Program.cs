using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                Console.Clear();

                // CREATE NEW TAG
                // var tag = new Tag { Name = ".NET", Slug = "dotnet" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag2 = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                // context.Tags.Add(tag2);
                // context.SaveChanges();

                // UPDATE TAG
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // DELETE TAG
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

                // context.Remove(tag);
                // context.SaveChanges();

                // READ
                // var tags = context.Tags.Where(x => x.Name.Contains(".NET")).ToList();
                // var tags = context.Tags.ToList();
                // var tags = context.Tags.AsNoTracking().ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // FIRST / SINGLE
                var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 2);
                // var tag = context.Tags.AsNoTracking().First(x => x.Id == 2);
                // var tag = context.Tags.AsNoTracking().Single(x => x.Id == 2);
                // var tag = context.Tags.AsNoTracking().SingleOrDefault(x => x.Id == 2);
                Console.WriteLine(tag?.Name);
            }
        }
    }
}