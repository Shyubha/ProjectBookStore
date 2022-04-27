using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectBookStore.Models
{
    [Table("usersaccounts")]
    public class UserAccount 
    {
        [Key]
        
        public int Id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public int role { get; set; }
        
        public string email { get; set; }

        
            

        
    }
}
