using Business.Aspects.Secured;
using Business.Repositories.PaymentMethodRepository.Constants;
using Business.Repositories.PaymentMethodRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.PaymentMethodRepository;
using Entities.Concrete;

namespace Business.Repositories.PaymentMethodRepository
{
    public class PaymentMethodManager : IPaymentMethodService
    {
        private readonly IPaymentMethodDal _paymentmethodDal;
        public PaymentMethodManager(IPaymentMethodDal paymentmethodDal)
        {
            _paymentmethodDal = paymentmethodDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(PaymentMethodValidator))]
        [RemoveCacheAspect("IPaymentMethodService.Get")]
        public async Task<IResult> Add(PaymentMethod paymentmethod)
        {
            await _paymentmethodDal.Add(paymentmethod);
            return new SuccessResult(PaymentMethodMessages.AddedPaymentMethod);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IPaymentMethodService.Get")]
        public async Task<IResult> Delete(PaymentMethod paymentmethod)
        {
            await _paymentmethodDal.Delete(paymentmethod);
            return new SuccessResult(PaymentMethodMessages.DeletedPaymentMethod);
        }

        public async Task<IDataResult<PaymentMethod>> GetById(int id)
        {
            return new SuccessDataResult<PaymentMethod>(await _paymentmethodDal.Get(p => p.Id == id));
        }

        public async Task<PaymentMethod> GetFirst()
        {
            return await _paymentmethodDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<PaymentMethod>>> GetList()
        {
            return new SuccessDataResult<List<PaymentMethod>>(await _paymentmethodDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(PaymentMethodValidator))]
        [RemoveCacheAspect("IPaymentMethodService.Get")]
        public async Task<IResult> Update(PaymentMethod paymentmethod)
        {
            await _paymentmethodDal.Update(paymentmethod);
            return new SuccessResult(PaymentMethodMessages.UpdatedPaymentMethod);
        }
    }
}
