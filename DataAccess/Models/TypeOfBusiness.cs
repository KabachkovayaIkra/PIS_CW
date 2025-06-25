using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("public.types_of_business")]
    public class TypeOfBusiness
    {
        [Key]
        [Column("type_of_business_id")]
        public int TypeOfBusinessId { get; set; }

        [Column("type_of_business_name")]
        public string TypeOfBusinessName { get; set; }
    }
}
