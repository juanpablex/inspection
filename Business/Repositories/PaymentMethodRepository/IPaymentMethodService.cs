using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.PaymentMethodRepository
{
    public interface IPaymentMethodService
    {
        Task<IResult> Add(PaymentMethod paymentmethod);
        Task<IResult> Update(PaymentMethod paymentmethod);
        Task<IResult> Delete(PaymentMethod paymentmethod);
        Task<IDataResult<List<PaymentMethod>>> GetList();
        Task<IDataResult<PaymentMethod>> GetById(int id);
        Task<PaymentMethod> GetFirst();
    }
}
