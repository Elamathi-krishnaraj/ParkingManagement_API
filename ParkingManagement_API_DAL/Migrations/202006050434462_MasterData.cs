namespace ParkingManagement_API_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class MasterData : DbMigration
    {
        public override void Up()
        {
            // Roles table 
            Sql("Insert Into dbo.UserRoles(RoleName) values('Admin');" +
               "Insert Into dbo.UserRoles(RoleName) values('User');");
            // Duration Table 
            Sql("Insert Into dbo.RequestDurationTypes(DurationType,DurationDescription) values('1','Day');" +
              "Insert Into dbo.RequestDurationTypes(DurationType,DurationDescription) values('7','Week');" +
              "Insert Into dbo.RequestDurationTypes(DurationType,DurationDescription) values('30','Month');");
            // Tower table 
            Sql("Insert Into dbo.Towers(TowerDescription) values('Tower 1');" +
             "Insert Into dbo.Towers(TowerDescription) values('Tower 2');" +
             "Insert Into dbo.Towers(TowerDescription) values('Tower 3');");
            // ParkingSlot Table 
            Sql("Insert Into dbo.ParkingSlots(SlotDescription) values('A-001');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('A-002');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('A-003');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('A-004');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('A-005');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('B-001'); " +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('B-002');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('B-003');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('B-004');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('B-005');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('C-001'); " +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('C-002');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('C-003');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('C-004');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('C-005');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('D-001'); " +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('D-002');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('D-003');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('D-004');" +
             "Insert Into dbo.ParkingSlots(SlotDescription) values('D-005');");
            // TowerSlot table
            Sql("Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,1);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,2);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,3);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,4);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,5);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,6);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,7);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,8);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,9);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,10);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,11);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,12);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,13);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,14);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,15);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,16);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,17);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,18);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,19);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(1,20);" +

                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,1);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,2);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,3);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,4);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,5);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,6);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,7);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,8);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,9);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,10);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,11);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,12);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,13);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,14);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,15);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,16);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,17);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,18);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,19);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(2,20);" +

                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,1);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,2);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,3);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,4);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,5);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,6);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,7);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,8);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,9);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,10);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,11);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,12);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,13);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,14);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,15);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,16);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,17);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,18);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,19);" +
                "Insert Into dbo.TowerParkingSlots(TowerId,ParkingSlotId) values(3,20);");
        }

        public override void Down()
        {
        }
    }
}
