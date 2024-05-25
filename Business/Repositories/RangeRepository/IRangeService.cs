using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.RangeRepository
{
    public interface IRangeService
    {
        Task<IResult> Add(Entities.Concrete.Range range);
        Task<IResult> Update(Entities.Concrete.Range range);
        Task<IResult> Delete(Entities.Concrete.Range range);
        Task<IDataResult<List<Entities.Concrete.Range>>> GetList();
        Task<IDataResult<Entities.Concrete.Range>> GetById(int id);
        Task<Entities.Concrete.Range> GetFirst();
    }
}
