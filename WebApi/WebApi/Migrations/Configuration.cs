namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApi.Models.BookServiceContext context)
        {

            
            context.Authors.AddOrUpdate(x => x.Id,
        new Author() { Id = 1, Name = "Jane Austen" },
        new Author() { Id = 2, Name = "Charles Dickens" },
        new Author() { Id = 3, Name = "Miguel de Cervantes" }
        );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    AuthorId = 1,
                    Price = 9.99M,
                    Genre = "Comedy of manners"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    AuthorId = 1,
                    Price = 12.95M,
                    Genre = "Gothic parody"
                },
                new Book()
                {
                    Id = 3,
                    Title = "David Copperfield",
                    Year = 1850,
                    AuthorId = 2,
                    Price = 15,
                    Genre = "Bildungsroman"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    AuthorId = 3,
                    Price = 8.95M,
                    Genre = "Picaresque"
                }
                );
            
            //CONTACT
            context.Contacts.AddOrUpdate(x => x.Id,
                   new Contact() { Id = 1, FirstName = "Jane", LastName = "Austen" },
                   new Contact() { Id = 2, FirstName = "Charles", LastName = "Dickens" },
                   new Contact() { Id = 3, FirstName = "Miguel", LastName = "de Cervantes" }
            );
            //EMAIL
            context.Emails.AddOrUpdate(x => x.Id,
                new Email() { Id = 1, Contact_Email = "jane.austen@gmail.com", ContactId = 1 },
                new Email() { Id = 2, Contact_Email = "charles.dickens@gmail.com", ContactId = 2 },
                new Email() { Id = 3, Contact_Email = "miguel.decervantes@gmail.com", ContactId = 3 });
            //
            context.Phones.AddOrUpdate(x => x.Id,
                new Phone() { Id = 1, Contact_Phone = "809-594-4556", ContactId = 1 },
                new Phone() { Id = 2, Contact_Phone = "809-594-4561", ContactId = 2 },
                new Phone() { Id = 3, Contact_Phone = "829-578-4562", ContactId = 3 });


        }
    }
}
