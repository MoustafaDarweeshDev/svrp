using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entities
{
    public class WhiteListFormPayments
    {
        [Key]
        public int Id { get; set; }
        public string PaymentId { get; set; }
        public string Discord { get; set; }
        public int Tier { get; set; }
        public string PayerId { get; set; }
        public string PayerEmail { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

