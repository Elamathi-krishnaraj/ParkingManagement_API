namespace ParkingManagement_API_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actionlogs",
                c => new
                    {
                        ActionLogId = c.Int(nullable: false, identity: true),
                        ControllerDescrption = c.String(),
                        ActionExectionInfo = c.String(),
                        IPAddressInfo = c.String(),
                        ExectionTime = c.String(),
                    })
                .PrimaryKey(t => t.ActionLogId);
            
            CreateTable(
                "dbo.ParkingAllocations",
                c => new
                    {
                        ParkingAllocationId = c.Int(nullable: false, identity: true),
                        RegisterId = c.Int(nullable: false),
                        DurationId = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        TowerParkingSlotId = c.Int(nullable: false),
                        IsSurrender = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ParkingAllocationId)
                .ForeignKey("dbo.Registers", t => t.RegisterId, cascadeDelete: true)
                .ForeignKey("dbo.RequestDurationTypes", t => t.DurationId, cascadeDelete: true)
                .ForeignKey("dbo.TowerParkingSlots", t => t.TowerParkingSlotId, cascadeDelete: true)
                .Index(t => t.RegisterId)
                .Index(t => t.DurationId)
                .Index(t => t.TowerParkingSlotId);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        RegisterId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        EmployeeName = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegisterId)
                .ForeignKey("dbo.UserRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.RequestDurationTypes",
                c => new
                    {
                        DurationId = c.Int(nullable: false, identity: true),
                        DurationType = c.String(),
                        DurationDescription = c.String(),
                    })
                .PrimaryKey(t => t.DurationId);
            
            CreateTable(
                "dbo.TowerParkingSlots",
                c => new
                    {
                        TowerParkingSlotId = c.Int(nullable: false, identity: true),
                        ParkingSlotId = c.Int(nullable: false),
                        TowerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TowerParkingSlotId)
                .ForeignKey("dbo.ParkingSlots", t => t.ParkingSlotId, cascadeDelete: true)
                .ForeignKey("dbo.Towers", t => t.TowerId, cascadeDelete: true)
                .Index(t => t.ParkingSlotId)
                .Index(t => t.TowerId);
            
            CreateTable(
                "dbo.ParkingSlots",
                c => new
                    {
                        ParkingSlotId = c.Int(nullable: false, identity: true),
                        SlotDescription = c.String(),
                    })
                .PrimaryKey(t => t.ParkingSlotId);
            
            CreateTable(
                "dbo.Towers",
                c => new
                    {
                        TowerId = c.Int(nullable: false, identity: true),
                        TowerDescription = c.String(),
                    })
                .PrimaryKey(t => t.TowerId);
            
            CreateTable(
                "dbo.RequestDetails",
                c => new
                    {
                        RequestDetailsId = c.Int(nullable: false, identity: true),
                        RegisterId = c.Int(nullable: false),
                        DurationId = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        PreferenceOneTowerId = c.Int(nullable: false),
                        PreferenceTwoTowerId = c.Int(nullable: false),
                        PreferenceThreeTowerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RequestDetailsId)
                .ForeignKey("dbo.Registers", t => t.RegisterId, cascadeDelete: true)
                .ForeignKey("dbo.RequestDurationTypes", t => t.DurationId, cascadeDelete: true)
                .Index(t => t.RegisterId)
                .Index(t => t.DurationId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.SlotRequestDeatils",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        Remarks = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        IsSlotAllotted = c.Boolean(nullable: false),
                        EmployeeName = c.String(),
                        IsSurrender = c.Boolean(nullable: false),
                        RegisterId = c.Int(nullable: false),
                        DurationId = c.Int(nullable: false),
                        TowerId = c.Int(nullable: false),
                        TowerBlockId = c.Int(nullable: false),
                        TowerBlockSlotId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.Registers", t => t.RegisterId, cascadeDelete: true)
                .ForeignKey("dbo.RequestDurationTypes", t => t.DurationId, cascadeDelete: true)
                .ForeignKey("dbo.Towers", t => t.TowerId, cascadeDelete: true)
                .ForeignKey("dbo.TowerBlocks", t => t.TowerBlockId, cascadeDelete: true)
                .ForeignKey("dbo.TowerBlockSlots", t => t.TowerBlockSlotId, cascadeDelete: true)
                .Index(t => t.RegisterId)
                .Index(t => t.DurationId)
                .Index(t => t.TowerId)
                .Index(t => t.TowerBlockId)
                .Index(t => t.TowerBlockSlotId);
            
            CreateTable(
                "dbo.TowerBlocks",
                c => new
                    {
                        TowerBlockId = c.Int(nullable: false, identity: true),
                        BlockDescription = c.String(),
                    })
                .PrimaryKey(t => t.TowerBlockId);
            
            CreateTable(
                "dbo.TowerBlockSlots",
                c => new
                    {
                        TowerBlockSlotId = c.Int(nullable: false, identity: true),
                        SlotDescription = c.String(),
                    })
                .PrimaryKey(t => t.TowerBlockSlotId);
            
            CreateTable(
                "dbo.SurrenderHistories",
                c => new
                    {
                        SurrenderHistoryId = c.Int(nullable: false, identity: true),
                        RegisterId = c.Int(nullable: false),
                        DurationId = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        TowerParkingSlotId = c.Int(nullable: false),
                        IsSurrender = c.Boolean(nullable: false),
                        IsExpires = c.Boolean(nullable: false),
                        IsAllotted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SurrenderHistoryId)
                .ForeignKey("dbo.Registers", t => t.RegisterId, cascadeDelete: true)
                .ForeignKey("dbo.RequestDurationTypes", t => t.DurationId, cascadeDelete: true)
                .ForeignKey("dbo.TowerParkingSlots", t => t.TowerParkingSlotId, cascadeDelete: true)
                .Index(t => t.RegisterId)
                .Index(t => t.DurationId)
                .Index(t => t.TowerParkingSlotId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SurrenderHistories", "TowerParkingSlotId", "dbo.TowerParkingSlots");
            DropForeignKey("dbo.SurrenderHistories", "DurationId", "dbo.RequestDurationTypes");
            DropForeignKey("dbo.SurrenderHistories", "RegisterId", "dbo.Registers");
            DropForeignKey("dbo.SlotRequestDeatils", "TowerBlockSlotId", "dbo.TowerBlockSlots");
            DropForeignKey("dbo.SlotRequestDeatils", "TowerBlockId", "dbo.TowerBlocks");
            DropForeignKey("dbo.SlotRequestDeatils", "TowerId", "dbo.Towers");
            DropForeignKey("dbo.SlotRequestDeatils", "DurationId", "dbo.RequestDurationTypes");
            DropForeignKey("dbo.SlotRequestDeatils", "RegisterId", "dbo.Registers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.RequestDetails", "DurationId", "dbo.RequestDurationTypes");
            DropForeignKey("dbo.RequestDetails", "RegisterId", "dbo.Registers");
            DropForeignKey("dbo.ParkingAllocations", "TowerParkingSlotId", "dbo.TowerParkingSlots");
            DropForeignKey("dbo.TowerParkingSlots", "TowerId", "dbo.Towers");
            DropForeignKey("dbo.TowerParkingSlots", "ParkingSlotId", "dbo.ParkingSlots");
            DropForeignKey("dbo.ParkingAllocations", "DurationId", "dbo.RequestDurationTypes");
            DropForeignKey("dbo.ParkingAllocations", "RegisterId", "dbo.Registers");
            DropForeignKey("dbo.Registers", "RoleId", "dbo.UserRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.SurrenderHistories", new[] { "TowerParkingSlotId" });
            DropIndex("dbo.SurrenderHistories", new[] { "DurationId" });
            DropIndex("dbo.SurrenderHistories", new[] { "RegisterId" });
            DropIndex("dbo.SlotRequestDeatils", new[] { "TowerBlockSlotId" });
            DropIndex("dbo.SlotRequestDeatils", new[] { "TowerBlockId" });
            DropIndex("dbo.SlotRequestDeatils", new[] { "TowerId" });
            DropIndex("dbo.SlotRequestDeatils", new[] { "DurationId" });
            DropIndex("dbo.SlotRequestDeatils", new[] { "RegisterId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.RequestDetails", new[] { "DurationId" });
            DropIndex("dbo.RequestDetails", new[] { "RegisterId" });
            DropIndex("dbo.TowerParkingSlots", new[] { "TowerId" });
            DropIndex("dbo.TowerParkingSlots", new[] { "ParkingSlotId" });
            DropIndex("dbo.Registers", new[] { "RoleId" });
            DropIndex("dbo.ParkingAllocations", new[] { "TowerParkingSlotId" });
            DropIndex("dbo.ParkingAllocations", new[] { "DurationId" });
            DropIndex("dbo.ParkingAllocations", new[] { "RegisterId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.SurrenderHistories");
            DropTable("dbo.TowerBlockSlots");
            DropTable("dbo.TowerBlocks");
            DropTable("dbo.SlotRequestDeatils");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RequestDetails");
            DropTable("dbo.Towers");
            DropTable("dbo.ParkingSlots");
            DropTable("dbo.TowerParkingSlots");
            DropTable("dbo.RequestDurationTypes");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Registers");
            DropTable("dbo.ParkingAllocations");
            DropTable("dbo.Actionlogs");
        }
    }
}
