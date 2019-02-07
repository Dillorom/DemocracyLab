using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace DemocracyLab.Models
{
    public class Vote
    {
        public Guid Id { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Value { get; set; }

        public int BillId { get; set; }

        public int VoterId { get; set; }
    }
}