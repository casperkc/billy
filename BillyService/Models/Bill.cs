﻿using Billy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillyService.Models
{
    public class BillRoot
    {
        public Meta meta { get; set; }
        public Bill bill { get; set; }
        public List<Bill> bills { get; set; }
        public List<BillLine> billLines { get; set; }
        public List<Transaction> transactions { get; set; }
        public List<Posting> postings { get; set; }
    }

    public class Bill
    {
        public string id { get; set; }
        public string organizationId { get; set; }
        public string type { get; set; }
        public string createdTime { get; set; }
        public string approvedTime { get; set; }
        public string contactId { get; set; }
        public object contactName { get; set; }
        public string entryDate { get; set; }
        public object paymentAccountId { get; set; }
        public object paymentDate { get; set; }
        public object dueDate { get; set; }
        public bool isBare { get; set; }
        public string state { get; set; }
        public string suppliersInvoiceNo { get; set; }
        public string taxMode { get; set; }
        public string voucherNo { get; set; }
        public double amount { get; set; }
        public double tax { get; set; }
        public string currencyId { get; set; }
        public int exchangeRate { get; set; }
        public int balance { get; set; }
        public bool isPaid { get; set; }
        public string lineDescription { get; set; }
        public object creditedBillId { get; set; }
        public object source { get; set; }
        public object subject { get; set; }
        public List<BillLine> lines { get; set; }
    }

    public class BillLine
    {
        public string id { get; set; }
        public string billId { get; set; }
        public string accountId { get; set; }
        public string taxRateId { get; set; }
        public string description { get; set; }
        public int amount { get; set; }
        public double tax { get; set; }
        public int priority { get; set; }
    }
}
