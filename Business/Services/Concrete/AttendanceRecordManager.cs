using System;
using System.Collections.Generic;
using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;

namespace Business.Services.Concrete
{
    public class AttendanceRecordManager : IAttendanceRecordService
    {
        private readonly IAttendanceRecordDal _attendanceRecordDal;

        public AttendanceRecordManager(IAttendanceRecordDal attendanceRecordDal)
        {
            _attendanceRecordDal = attendanceRecordDal;
        }

        public void Create(AttendanceRecord entity)
        {
            _attendanceRecordDal.Add(entity);
        }

        public void Update(AttendanceRecord entity)
        {
            _attendanceRecordDal.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _attendanceRecordDal.Get(x => x.Id == id);
            if (entity != null)
            {
                _attendanceRecordDal.Delete(entity);
            }
        }

        public AttendanceRecord GetById(int id)
        {
            return _attendanceRecordDal.Get(x => x.Id == id);
        }

        public List<AttendanceRecord> GetAll()
        {
            return _attendanceRecordDal.GetAll();
        }

        public List<AttendanceRecord> GetByEmployeeId(int employeeId)
        {
            return _attendanceRecordDal.GetAll(x => x.EmployeeId == employeeId);
        }

        public List<AttendanceRecord> GetByDateRange(int employeeId, DateTime startDate, DateTime endDate)
        {
            return _attendanceRecordDal.GetAll(x =>
                x.EmployeeId == employeeId &&
                x.Date >= startDate &&
                x.Date <= endDate);
        }

        public List<AttendanceRecord> GetByCompanyId(int companyId, DateTime? date = null)
        {
            if (date.HasValue)
            {
                return _attendanceRecordDal.GetAll(x =>
                    x.CompanyId == companyId && x.Date.Date == date.Value.Date);
            }

            return _attendanceRecordDal.GetAll(x => x.CompanyId == companyId);
        }
    }
}
