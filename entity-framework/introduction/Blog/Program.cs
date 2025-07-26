using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Introdução
            // using (var context = new BlogDataContext())
            // {

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
            // var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 2);
            // var tag = context.Tags.AsNoTracking().First(x => x.Id == 2);
            // var tag = context.Tags.AsNoTracking().Single(x => x.Id == 2);
            // var tag = context.Tags.AsNoTracking().SingleOrDefault(x => x.Id == 2);
            // Console.WriteLine(tag?.Name);
            // }

            // Operações básicas
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "André Balta",
            //     Slug = "andrebalta",
            //     Email = "andre@gmail.com",
            //     Bio = "Texto para Bio",
            //     Image = "https://balta.io",
            //     PasswordHash = "123456789",
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend",
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF core",
            //     Title = "Começando com EF core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // INCLUDE
            // var posts = context
            //             .Posts
            //             .AsNoTracking()
            //             .Include(x => x.Author)
            //             .OrderBy(x => x.LastUpdateDate)
            //             .ToList();

            // foreach (var post in posts)
            // {
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            // }

            // UPDATE
            var post = context
                        .Posts
                        // .AsNoTracking()
                        .Include(x => x.Author)
                        .Include(x => x.Category)
                        .OrderByDescending(x => x.LastUpdateDate)
                        .FirstOrDefault();

            post.Author.Name = "Teste";

            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}