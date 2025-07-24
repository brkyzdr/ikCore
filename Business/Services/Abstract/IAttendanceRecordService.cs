using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IAttendanceRecordService
    {
        void Create(AttendanceRecord entity);
        void Update(AttendanceRecord entity);
        void Delete(int id);

        AttendanceRecord GetById(int id);
        List<AttendanceRecord> GetAll();
        List<AttendanceRecord> GetByEmployeeId(int employeeId);
        List<AttendanceRecord> GetByDateRange(int employeeId, DateTime startDate, DateTime endDate);
        List<AttendanceRecord> GetByCompanyId(int companyId, DateTime? date = null);
    }
}
