using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public int Number { get; set; }
        public int ClientId { get; set; }
		public Person Client {get; set; }
        public string Garante { get; set; }
        public string GarantePhone { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Promocion { get; set; }
        public decimal TotalEffectivePayment { get; set; }
        public decimal EffectiveInitialPayment { get; set; }
        public decimal DeferredInitialPayment { get; set; }
        public decimal DeferredInitialPaymentTime { get; set; }
        public int Quantity { get; set; }
        public int CreditSalesTerm { get; set; }
        public decimal StatedPriceCharged { get; set; }
        public decimal TotalSalesAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal BaseAmountForCommission { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public decimal Commission { get; set; }
        public int RangeId { get; set; }
        public Range Range { get; set; }
        public string AuthsAndObservations { get; set; }
    }
}
