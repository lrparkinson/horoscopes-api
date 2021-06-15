using System.Threading.Tasks;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.DataAccess
{
    interface IPositiveAbstractNounRepository:IGenericRepository<PositiveAbstractNoun>
    {
        public Task<PositiveAbstractNoun> GetRandomPositiveAbstractNoun();
    }
}
