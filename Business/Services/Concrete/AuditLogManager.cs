using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class AuditLogManager : IAuditLogService
    {
        private readonly IAuditLogDal _auditLogDal;

        public AuditLogManager(IAuditLogDal auditLogDal)
        {
            _auditLogDal = auditLogDal;
        }

        public void LogAction(AuditLog log)
        {
            log.Timestamp = DateTime.UtcNow;
            _auditLogDal.Add(log);
        }

        public List<AuditLog> GetAll()
        {
            return _auditLogDal.GetAll().ToList();
        }

        public AuditLog GetById(int id)
        {
            return _auditLogDal.Get(a => a.Id == id);
        }

        public List<AuditLog> GetByUserId(int userId)
        {
            return _auditLogDal.GetAll(a => a.UserId == userId).ToList();
        }

        public List<AuditLog> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return _auditLogDal.GetAll(a => a.Timestamp >= startDate && a.Timestamp <= endDate).ToList();
        }

        public List<AuditLog> GetByCompanyId(int companyId)
        {
            return _auditLogDal.GetAll(a => a.CompanyId == companyId).ToList();
        }
    }
}
