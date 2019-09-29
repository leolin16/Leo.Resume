using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Leo.Resume.Entities
{
    public class ResumeUser: IdentityUser
    {
        public string Comment { get; set; }
        public Sex Gender { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]      
        public int Age 
        {
            get { /* do your sum here */ 
                int age = 0;  
                age = DateTime.Now.Year - DateOfBirth.Year;  
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)  
                    age = age - 1;  
                return age;
            }
            private set { /* needed for EF */ }
        }
        public Date DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Passport { get; set; }
        public string MobileNo { get; set; }
        public string Email3rd { get; set; }
        public string EmailPri { get; set; }
        public string HomeAddressCHN { get; set; }
        public string HomeAddressJPN { get; set; }
        public string HomeAddressENG { get; set; }
        public Marital MaritalStatus { get; set; }
        public string CharactersCHN { get; set; }
        public string CharactersJPN { get; set; }
        public string CharactersENG { get; set; }
        public string WorkHabbitsCHN { get; set; }
        public string WorkHabbitsJPN { get; set; }
        public string WorkHabbitsENG { get; set; }
        public string NameEng { get; set; }
        public string NameJpn { get; set; }
        public string NameChn { get; set; }
        public string ImagePortraitName { get; set; }
        public string ImageLifeName { get; set; }
        
    }
}