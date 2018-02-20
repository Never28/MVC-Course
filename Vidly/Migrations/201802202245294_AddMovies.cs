namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Hangover', 2, GETDATE(), '2009-01-01', 1)");
            Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Die Hard', 1, GETDATE(), '1988-01-01', 1)");
            Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('The Terminator', 1, GETDATE(), '1984-01-01', 1)");
            Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Toy Story', 3, GETDATE(), '1995-01-01', 1)");
            Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Titanic', 4, GETDATE(), '1997-01-01', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
