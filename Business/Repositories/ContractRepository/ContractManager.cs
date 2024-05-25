using Business.Aspects.Secured;
using Business.Repositories.ContractRepository.Constants;
using Business.Repositories.ContractRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.ContractRepository;
using Entities.Concrete;

namespace Business.Repositories.ContractRepository
{
    public class ContractManager : IContractService
    {
        private readonly IContractDal _contractDal;
        public ContractManager(IContractDal contractDal)
        {
            _contractDal = contractDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(ContractValidator))]
        [RemoveCacheAspect("IContractService.Get")]
        public async Task<IResult> Add(Contract contract)
        {
            await _contractDal.Add(contract);
            return new SuccessResult(ContractMessages.AddedContract);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IContractService.Get")]
        public async Task<IResult> Delete(Contract contract)
        {
            await _contractDal.Delete(contract);
            return new SuccessResult(ContractMessages.DeletedContract);
        }

        public async Task<IDataResult<Contract>> GetById(int id)
        {
            return new SuccessDataResult<Contract>(await _contractDal.Get(p => p.Id == id));
        }

        public async Task<Contract> GetFirst()
        {
            return await _contractDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Contract>>> GetList()
        {
            return new SuccessDataResult<List<Contract>>(await _contractDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(ContractValidator))]
        [RemoveCacheAspect("IContractService.Get")]
        public async Task<IResult> Update(Contract contract)
        {
            await _contractDal.Update(contract);
            return new SuccessResult(ContractMessages.UpdatedContract);
        }
    }
}
