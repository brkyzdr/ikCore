using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IAuditLogService
    {
        void LogAction(AuditLog log); // Yeni işlem kaydı eklemek için
        List<AuditLog> GetAll();
        AuditLog GetById(int id);

        List<AuditLog> GetByUserId(int userId);
        List<AuditLog> GetByDateRange(DateTime startDate, DateTime endDate);
        List<AuditLog> GetByCompanyId(int companyId);
    }
}
