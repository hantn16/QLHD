﻿using QLHD.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Model.Models
{
    [Table("Invoice")]
    public class Invoice : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [StringLength(7)]
        [Display(Name = "Số hóa đơn")]
        public string Number { get; set; }
        
        [Display(Name = "Ngày hóa đơn")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime ReleaseDate { get; set; }

        [DisplayFormat(DataFormatString = "n0")]
        [Display(Name ="GT trước thuế")]
        public double PretaxValue { get; set; }

        [DisplayFormat(DataFormatString = "n0")]
        [Display(Name ="Thuế GTGT")]
        public double VatValue { get; set; }

        [Display(Name = "Mã Lần TT")]
        public int PaymentPeriodId { get; set; }

        [Display(Name = "Lần TT")]
        [ForeignKey("PaymentPeriodId")]
        public virtual PaymentPeriod PaymentPeriod { get; set; }

        [Display(Name = "GT thanh toán")]
        [DisplayFormat(DataFormatString = "n0")]
        public double PayValue {
            get {
                return PretaxValue + VatValue;
            }
        }

        public override string ToString()
        {
            return Number;
        }

    }
}
