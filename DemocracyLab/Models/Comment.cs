using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemocracyLab.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        [Required]
        public string Content { get; set; }

        public int VoterId { get; set; }

        public int BillId { get; set; }
    }
}