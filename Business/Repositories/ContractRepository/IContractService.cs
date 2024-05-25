using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ContractRepository
{
    public interface IContractService
    {
        Task<IResult> Add(Contract contract);
        Task<IResult> Update(Contract contract);
        Task<IResult> Delete(Contract contract);
        Task<IDataResult<List<Contract>>> GetList();
        Task<IDataResult<Contract>> GetById(int id);
        Task<Contract> GetFirst();
    }
}
