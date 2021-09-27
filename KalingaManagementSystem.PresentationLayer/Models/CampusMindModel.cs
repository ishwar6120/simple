using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KalingaManagementSystem.PresentationLayer.Models
{
    public class CampusMindModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required.")]
        public DateTime DateOfJoin { get; set; }

        [Required(ErrorMessage = "ContactNumber is required.")]
        public int ContactNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "LeadId is required.")]
        public int LeadId { get; set; }
    }
}