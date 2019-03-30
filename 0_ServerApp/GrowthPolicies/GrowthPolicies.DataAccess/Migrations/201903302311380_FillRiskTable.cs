namespace GrowthPolicies.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillRiskTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Risks (Id, Name) VALUES (1, 'Low')");
            Sql("INSERT INTO Risks (Id, Name) VALUES (2, 'Half')");
            Sql("INSERT INTO Risks (Id, Name) VALUES (3, 'Half-Hight')");
            Sql("INSERT INTO Risks (Id, Name) VALUES (4, 'Hight')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Risks WHERE Id IN (1,2,3,4)");
        }
    }
}
