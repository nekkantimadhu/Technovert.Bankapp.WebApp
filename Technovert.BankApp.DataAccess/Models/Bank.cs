using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Technovert.BankApp.DataAccess.Models
{
    
        [Table("Bank", Schema = "dbo")]
        public class Bank
        {

            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public string Id { get; set; }
            [Required]
            [Display(Name = "BankName")]
            public string BankName { get; set; }

            [Display(Name = "IsDeleted")]
            public bool IsDeleted { get; set; } = false;
        }
    
}
