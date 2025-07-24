using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface IRecruitmentPostService
    {
        void Create(RecruitmentPost entity);
        void Update(RecruitmentPost entity);
        void Delete(int id);

        RecruitmentPost GetById(int id);
        List<RecruitmentPost> GetAll();
        List<RecruitmentPost> GetByCompanyId(int companyId);
        List<RecruitmentPost> GetActivePosts(); // Yayında olan ilanlar
    }
}
