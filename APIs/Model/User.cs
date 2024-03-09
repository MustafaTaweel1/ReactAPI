using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webAPI.Model
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public required string userName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public required string email { get; set; }
        [DataType(DataType.Password)]
        public required string password { get; set; }
		public required int age { get; set; }

		public required string access { get; set; }




	}
}
