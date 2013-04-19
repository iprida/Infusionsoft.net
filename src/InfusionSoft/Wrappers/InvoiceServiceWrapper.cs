#region License

// Copyright (c) 2012, EventDay
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
// Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
// Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using CookComputing.XmlRpc;
using InfusionSoft.Definition;


namespace InfusionSoft
{
    
    
    internal partial class InvoiceServiceWrapper : ServiceBase<IInvoiceServiceDefinition>, IInvoiceService
    {
        
        public InvoiceServiceWrapper(InfusionSoft.IInfusionSoftConfiguration configuration, InfusionSoft.IMethodListenerProvider listenerProvider) : 
                base(configuration, listenerProvider)
        {
        }
        
        public virtual int CreateBlankOrder(int contactId, string description, System.DateTime orderDate, int leadAffiliateId, int saleAffiliateId)
        {
            return Invoke(d => d.CreateBlankOrder(ApiKey, contactId, description, orderDate, leadAffiliateId, saleAffiliateId));
        }
        
        public virtual bool AddOrderItem(int invoiceId, int productId, int type, double price, int quantity, string title, string description)
        {
            return Invoke(d => d.AddOrderItem(ApiKey, invoiceId, productId, type, price, quantity, title, description));
        }
        
        public virtual InfusionSoft.Definition.ChargeInvoiceResult ChargeInvoice(int invoiceId, string notes, int creditCardId, int merchantAccountId, bool bypassCommissions)
        {
            return Invoke(d => d.ChargeInvoice(ApiKey, invoiceId, notes, creditCardId, merchantAccountId, bypassCommissions));
        }
        
        public virtual bool DeleteSubscription(int recurringOrderId)
        {
            return Invoke(d => d.DeleteSubscription(ApiKey, recurringOrderId));
        }
        
        public virtual int AddRecurringOrder(int contactId, bool allowDuplicate, int cProgramId, int qty, double price, bool taxable, int merchantAccountId, int creditCardId, int affiliateId, int daysTillCharge)
        {
            return Invoke(d => d.AddRecurringOrder(ApiKey, contactId, allowDuplicate, cProgramId, qty, price, taxable, merchantAccountId, creditCardId, affiliateId, daysTillCharge));
        }
        
        public virtual bool AddRecurringCommissionOverride(int recurringOrderId, int affiliateId, double amount, int payoutType, string description)
        {
            return Invoke(d => d.AddRecurringCommissionOverride(ApiKey, recurringOrderId, affiliateId, amount, payoutType, description));
        }
        
        public virtual int CreateInvoiceForRecurring(int recurringOrderId)
        {
            return Invoke(d => d.CreateInvoiceForRecurring(ApiKey, recurringOrderId));
        }
        
        public virtual bool AddManualPayment(int invoiceId, double amt, System.DateTime paymentDate, string paymentType, string paymentDescription, bool bypassCommissions)
        {
            return Invoke(d => d.AddManualPayment(ApiKey, invoiceId, amt, paymentDate, paymentType, paymentDescription, bypassCommissions));
        }
        
        public virtual bool AddPaymentPlan(int invoiceId, bool autoCharge, int creditCardId, int merchantAccountId, int daysBetweenRetry, int maxRetry, double initialPmtAmt, System.DateTime initialPmtDate, System.DateTime planStartDate, int numPmts, int daysBetweenPmts)
        {
            return Invoke(d => d.AddPaymentPlan(ApiKey, invoiceId, autoCharge, creditCardId, merchantAccountId, daysBetweenRetry, maxRetry, initialPmtAmt, initialPmtDate, planStartDate, numPmts, daysBetweenPmts));
        }
        
        public virtual double CalculateAmountOwed(int invoiceId)
        {
            return Invoke(d => d.CalculateAmountOwed(ApiKey, invoiceId));
        }

        public virtual IDictionary<string, object> GetAllPaymentOptions()
        {
            var options = Invoke(d => d.GetAllPaymentOptions(ApiKey));
            return options.Keys.Cast<string>().ToDictionary(key => key, key => options[key]);
        }

        public virtual object GetPayments(int invoiceId)
        {
            return Invoke(d => d.GetPayments(ApiKey, invoiceId));
        }
        
        public virtual int LocateExistingCard(int contactId, int last4)
        {
            return Invoke(d => d.LocateExistingCard(ApiKey, contactId, last4));
        }
        
        public virtual bool RecalculateTax(int invoiceId)
        {
            return Invoke(d => d.RecalculateTax(ApiKey, invoiceId));
        }
        
        public virtual InfusionSoft.Definition.ValidateCreditCardResult ValidateCreditCard(int creditCardId)
        {
            return Invoke(d => d.ValidateCreditCard(ApiKey, creditCardId));
        }
        
        public virtual InfusionSoft.Definition.ValidateCreditCardResult ValidateCreditCard(InfusionSoft.Definition.CreditCardData data)
        {
            return Invoke(d => d.ValidateCreditCard(ApiKey, data));
        }
        
        public virtual object GetAllShippingOptions()
        {
            return Invoke(d => d.GetAllShippingOptions(ApiKey));
        }
        
        public virtual bool UpdateJobRecurringNextBillDate(int recurringOrderId, System.DateTime nextBillDate)
        {
            return Invoke(d => d.UpdateJobRecurringNextBillDate(ApiKey, recurringOrderId, nextBillDate));
        }
        
        public virtual bool AddOrderCommissionOverride(int invoiceId, int affiliateId, int productId, int percentage, double amount, int payoutType, string description, System.DateTime date)
        {
            return Invoke(d => d.AddOrderCommissionOverride(ApiKey, invoiceId, affiliateId, productId, percentage, amount, payoutType, description, date));
        }
    }
}
