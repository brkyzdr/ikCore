using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class LeaveManager : ILeaveService
    {
        private readonly ILeaveRequestDal _leaveRequestDal;

        public LeaveManager(ILeaveRequestDal leaveRequestDal)
        {
            _leaveRequestDal = leaveRequestDal;
        }

        public void Create(LeaveRequest entity)
        {
            entity.Status = ApplicationStatus.Pending.ToString();
            _leaveRequestDal.Add(entity);
        }

        public void Update(LeaveRequest entity)
        {
            _leaveRequestDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _leaveRequestDal.Get(x => x.Id == id);
            if (entity != null)
                _leaveRequestDal.Delete(entity);
        }

        public LeaveRequest GetById(int id)
        {
            return _leaveRequestDal.Get(x => x.Id == id);
        }

        public List<LeaveRequest> GetAll()
        {
            return _leaveRequestDal.GetAll().ToList();
        }

        public List<LeaveRequest> GetByEmployeeId(int employeeId)
        {
            return _leaveRequestDal.GetAll(x => x.EmployeeId == employeeId).ToList();
        }

        public List<LeaveRequest> GetByCompanyId(int companyId)
        {
            return _leaveRequestDal.GetAll(x => x.CompanyId == companyId).ToList();
        }

        public List<LeaveRequest> GetPendingRequestsByDepartment(int departmentId)
        {
            return _leaveRequestDal
                .GetAll(x => x.DepartmentId == departmentId && x.Status == ApplicationStatus.Pending.ToString())
                .ToList();
        }

        public void Approve(int id)
        {
            var entity = _leaveRequestDal.Get(x => x.Id == id);
            if (entity != null)
            {
                entity.Status = ApplicationStatus.Approved.ToString();
                _leaveRequestDal.Update(entity);
            }
        }

        public void Reject(int id)
        {
            var entity = _leaveRequestDal.Get(x => x.Id == id);
            if (entity != null)
            {
                entity.Status = ApplicationStatus.Rejected.ToString();
                _leaveRequestDal.Update(entity);
            }
        }
    }
}
