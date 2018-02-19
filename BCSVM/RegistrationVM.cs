using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BCSVM
{
    public class RegistrationVM
    {
        public int URID { get; set; }
        public string RegistrationNo { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string AadharCardNo { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DOB { get; set; }
        public string AlterNateContatNo { get; set; }
        public string Email { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<string> ddlCtegory { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }


    }
    public enum Gender
    {
        MALE = 0,
        FEMALE = 1,
        TRANSGENDER = 2,
    }
    public enum MaritalStatus
    {
        MARRIED=0,
        SINGLE=1,
        DIVORCED=2,
        WIDOW=3,
    }

}
