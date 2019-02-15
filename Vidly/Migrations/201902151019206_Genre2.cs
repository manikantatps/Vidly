namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Bahubali2',1,CAST('2018-06-30' AS DATETIME), CAST('2019-04-01' AS DATETIME),8)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Robo',1,CAST('2017-09-01' AS DATETIME), CAST('2019-04-01' AS DATETIME),3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Bharath Ana Nanu',3,CAST('2018-11-01' AS DATETIME), CAST('2019-04-01' AS DATETIME),12)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('2.0',1,CAST('2018-11-19' AS DATETIME), CAST('2019-04-01' AS DATETIME),5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Johnny',4,CAST('2010-06-10' AS DATETIME), CAST('2019-04-01' AS DATETIME),10)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('f2',5,CAST('2019-01-15' AS DATETIME), CAST('2019-04-01' AS DATETIME),30)");
        }
        
        public override void Down()
        {
        }
    }
}
