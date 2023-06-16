using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Domain;
using HRLeaveManagement.Persistence.DatabaseContext;

namespace HRLeaveManagement.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(HrDatabaseContext context) : base(context)
        {
        }

        public Task<List<LeaveRequest>> GetLeaveRequestsWithDefaults()
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveRequest> GetLeaveRequestWithDefaults(int id)
        {
            throw new NotImplementedException();
        }
    }
}
