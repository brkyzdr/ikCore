using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Repositories.Abstract
{
    public interface IRecruitmentPostDal : IGenericRepository<RecruitmentPost>
    {
        // Yayın durumu, firma ID veya pozisyona göre filtreleme burada tanımlanabilir
    }
}
