using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_tsteven6.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
           
        [Required(ErrorMessage ="You need to enter a title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need to enter a year")]
        public int Year { get; set; }
        [Required(ErrorMessage = "You need to enter a director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "You need to enter a rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

        //Build Foreign Key Relationship
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
