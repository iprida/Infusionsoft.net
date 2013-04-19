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

using System;
using System.Collections.Generic;
using CookComputing.XmlRpc;
using InfusionSoft.Definition;


namespace InfusionSoft
{
    
    
    public interface IInvoiceService : InfusionSoft.IService
    {
        
        int CreateBlankOrder(int contactId, string description, System.DateTime orderDate, int leadAffiliateId, int saleAffiliateId);
        
        bool AddOrderItem(int invoiceId, int productId, int type, double price, int quantity, string title, string description);
        
        InfusionSoft.Definition.ChargeInvoiceResult ChargeInvoice(int invoiceId, string notes, int creditCardId, int merchantAccountId, bool bypassCommissions);
        
        bool DeleteSubscription(int recurringOrderId);
        
        int AddRecurringOrder(int contactId, bool allowDuplicate, int cProgramId, int qty, double price, bool taxable, int merchantAccountId, int creditCardId, int affiliateId, int daysTillCharge);
        
        bool AddRecurringCommissionOverride(int recurringOrderId, int affiliateId, double amount, int payoutType, string description);
        
        int CreateInvoiceForRecurring(int recurringOrderId);
        
        bool AddManualPayment(int invoiceId, double amt, System.DateTime paymentDate, string paymentType, string paymentDescription, bool bypassCommissions);
        
        bool AddPaymentPlan(int invoiceId, bool autoCharge, int creditCardId, int merchantAccountId, int daysBetweenRetry, int maxRetry, double initialPmtAmt, System.DateTime initialPmtDate, System.DateTime planStartDate, int numPmts, int daysBetweenPmts);
        
        double CalculateAmountOwed(int invoiceId);

        IDictionary<string, object> GetAllPaymentOptions();
        
        object GetPayments(int invoiceId);
        
        int LocateExistingCard(int contactId, int last4);
        
        bool RecalculateTax(int invoiceId);
        
        InfusionSoft.Definition.ValidateCreditCardResult ValidateCreditCard(int creditCardId);
        
        InfusionSoft.Definition.ValidateCreditCardResult ValidateCreditCard(InfusionSoft.Definition.CreditCardData data);
        
        object GetAllShippingOptions();
        
        bool UpdateJobRecurringNextBillDate(int recurringOrderId, System.DateTime nextBillDate);
        
        bool AddOrderCommissionOverride(int invoiceId, int affiliateId, int productId, int percentage, double amount, int payoutType, string description, System.DateTime date);
    }
}
