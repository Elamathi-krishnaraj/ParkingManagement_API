using ParkingManagement_API_DAL;
using ParkingManagement_API_BL.Repositories;
using ParkingManagement_API_BL;
using ParkingManagement_API_DAL.Repositories;


namespace ParkingManagement_API_DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParkingManagementContext _parkingManagementContext;

        public UnitOfWork(ParkingManagementContext parkingManagementContext)
        {
            _parkingManagementContext = parkingManagementContext;
            Registers = new RegisterRepository(_parkingManagementContext);
            UserRoles = new RoleRepository(_parkingManagementContext);
            RequestDuationTypes = new RequestDuationTypeRepository(_parkingManagementContext);
            Tower = new TowerRepository(_parkingManagementContext);
            ParkingSlot = new ParkingSlotRepository(_parkingManagementContext);
            RequestDetails = new RequestDetailsRepository(_parkingManagementContext);
            ParkingAllocation = new ParkingAllocationRepository(_parkingManagementContext);
            SurrenderHistory = new SurrenderHistoryRepository(_parkingManagementContext);
            TowerParkingSlot = new TowerParkingSlotRepository(_parkingManagementContext);



            TowerBlock = new TowerBlockRepository(_parkingManagementContext);
            TowerBlockSlot = new TowerBlockSlotRepository(_parkingManagementContext);
            slotRequestDetails = new SlotRequestDetailsRepository(_parkingManagementContext);
        }

        public IRegisterRepository Registers { get; private set; }
        public IRoleRepository UserRoles { get; set; }
        public IRequestDuationTypeRepository RequestDuationTypes { get; private set; }
        public ITowerRepository Tower { get; private set; }
        public IParkingSlotRepository ParkingSlot { get; private set; }
        public IRequestDetailsRepository RequestDetails { get; set; }
        public IParkingAllocationRepository ParkingAllocation { get; private set; }
        public ISurrenderHistoryRepository SurrenderHistory { get; private set; }
        public ITowerParkingSlotRepository TowerParkingSlot { get; private set; }


        public ITowerBlockRepository TowerBlock { get; private set; }
        public ITowerBlockSlotRepository TowerBlockSlot { get; private set; }
        public ISlotRequestDetailsRepository slotRequestDetails { get; private set; }

        public void Complete()
        {
            _parkingManagementContext.SaveChanges();
        }

        public void Dispose()
        {
            _parkingManagementContext.Dispose();
        }
    }
}