using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Leo.ResumeProfile.Entities
{
    public class ResumeUser
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string Comment { get; set; }
        public Sex Gender { get; set; }

        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]      
        // public int Age 
        // {
        //     get { /* do your sum here */ 
        //         int age = 0;  
        //         age = DateTime.Now.Year - DateOfBirth.Year;  
        //         if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)  
        //             age = age - 1;  
        //         return age;
        //     }
        //     private set { /* needed for EF */ }
        // }
        public DateTimeOffset DateOfBirth { get; set; } // Date or DateTimeOffset
        [MaxLength(50)]
        public string PlaceOfBirth { get; set; }
        [MaxLength(50)]
        public string Passport { get; set; }
        public string MobileNo { get; set; }
        [MaxLength(50)]
        public string Email3rd { get; set; }
        [MaxLength(50)]
        public string EmailPri { get; set; }
        [MaxLength(50)]
        public string HomeAddressCHN { get; set; }
        [MaxLength(50)]
        public string HomeAddressJPN { get; set; }
        [MaxLength(50)]
        public string HomeAddressENG { get; set; }
        public Marital MaritalStatus { get; set; }
        [MaxLength(50)]
        public string CharactersCHN { get; set; }
        [MaxLength(50)]
        public string CharactersJPN { get; set; }
        [MaxLength(50)]
        public string CharactersENG { get; set; }
        [MaxLength(50)]
        public string WorkHabbitsCHN { get; set; }
        [MaxLength(50)]
        public string WorkHabbitsJPN { get; set; }
        [MaxLength(50)]
        public string WorkHabbitsENG { get; set; }
        [MaxLength(50)]
        public string NameEng { get; set; }
        [MaxLength(50)]
        public string NameJpn { get; set; }
        [MaxLength(50)]
        public string NameChn { get; set; }
        [MaxLength(50)]
        public string ImagePortraitName { get; set; }
        [MaxLength(50)]
        public string ImageLifeName { get; set; }

        public ICollection<Resume> Resumes { get; set; } = new List<Resume>();
        
    }
}