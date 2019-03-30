namespace GrowthPolicies.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class FillCoverageTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Coverages (Id, Name, Cover) VALUES (1, 'Earthquake', 70)");
            Sql("INSERT INTO Coverages (Id, Name, Cover) VALUES (2, 'Fire', 80)");
            Sql("INSERT INTO Coverages (Id, Name, Cover) VALUES (3, 'Robbery', 45)");
            Sql("INSERT INTO Coverages (Id, Name, Cover) VALUES (4, 'Loss', 40)");

        }

        public override void Down()
        {
            Sql("DELETE FROM Coverages WHERE Id IN (1,2,3,4)");
        }
    }
}
