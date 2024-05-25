using Business.Aspects.Secured;
using Business.Repositories.RangeRepository.Constants;
using Business.Repositories.RangeRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.RangeRepository;
using Entities.Concrete;

namespace Business.Repositories.RangeRepository
{
    public class RangeManager : IRangeService
    {
        private readonly IRangeDal _rangeDal;
        public RangeManager(IRangeDal rangeDal)
        {
            _rangeDal = rangeDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(RangeValidator))]
        [RemoveCacheAspect("IRangeService.Get")]
        public async Task<IResult> Add(Entities.Concrete.Range range)
        {
            await _rangeDal.Add(range);
            return new SuccessResult(RangeMessages.AddedRange);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IRangeService.Get")]
        public async Task<IResult> Delete(Entities.Concrete.Range range)
        {
            await _rangeDal.Delete(range);
            return new SuccessResult(RangeMessages.DeletedRange);
        }

        public async Task<IDataResult<Entities.Concrete.Range>> GetById(int id)
        {
            return new SuccessDataResult<Entities.Concrete.Range>(await _rangeDal.Get(p => p.Id == id));
        }

        public async Task<Entities.Concrete.Range> GetFirst()
        {
            return await _rangeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Entities.Concrete.Range>>> GetList()
        {
            return new SuccessDataResult<List<Entities.Concrete.Range>>(await _rangeDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(RangeValidator))]
        [RemoveCacheAspect("IRangeService.Get")]
        public async Task<IResult> Update(Entities.Concrete.Range range)
        {
            await _rangeDal.Update(range);
            return new SuccessResult(RangeMessages.UpdatedRange);
        }
    }
}
