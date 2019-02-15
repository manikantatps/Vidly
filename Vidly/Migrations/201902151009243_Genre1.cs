namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Bahubali',1,CAST('2017-03-01' AS DATETIME), CAST('2019-04-01' AS DATETIME),50)");
        }
        
        public override void Down()
        {
        }
    }
}
