using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Domain;
using HRLeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HrDatabaseContext _context;

        public LeaveTypeRepository(HrDatabaseContext context) : base(context)
        {
            this._context = context;
        }

        async Task<bool> ILeaveTypeRepository.IsLeaveTypeUnqiue(string name)
        {
            return await _context.LeaveTypes.AnyAsync(t => t.Name == name);
        }
    }
}
