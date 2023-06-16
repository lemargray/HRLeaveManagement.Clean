using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDefaults(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDefaults();
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);
    }
}
