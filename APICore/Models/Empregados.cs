using System.ComponentModel.DataAnnotations;

namespace APICore.Models
{
    public class Empregados
    {
        [Key]
        public int EmpregadoID { get; set; }
        public string FirsNameEmpl { get; set; }
        public string LastNameEmpl { get; set; }
        public string CorportionEmail { get; set; }
        public decimal Chapa { get; set; }
        public string PhoneNumber { get; set; }
        public string LeaderEmpl { get; set; }
        public int LeaderID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    /*public class PhoneNumberEmpl
    {
        public string PhoneNumber { get; set; }
    }*/
}
