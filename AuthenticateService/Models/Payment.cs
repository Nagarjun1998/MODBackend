﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    [Table("Paymentdtl")]
    public class Payment
    {
        [Key]
        public string PaymentId { get; set; }
        public double amount { get; set; }
        [ForeignKey("Userdtl")]
        public string UserId { get; set; }
        [ForeignKey("MentorDtl")]
        public string MentorId { get; set; }
        [ForeignKey("Training")]
        public string TrainingId { get; set; }
        public Nullable<double> AmountToMentor { get; set; }

        public Userdtl Userdtl { get; set; }

        public MentorDtl MentorDtl { get; set; }

        public Training Training { get; set; }
    }
}
