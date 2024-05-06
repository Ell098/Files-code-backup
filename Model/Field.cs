using FarmApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmApplication.Model
{
    public class Field
    {
        [Key]
        public int FieldID { get; set; }
        [Required]
        public string FieldName { get; set; }

        // this will change the display name of this property everywhere in the app unless overriden 
        [Display(Name = "Size (Acres)")]
        // largest farm in the uk is 25,000 acres 
        [Range(0, 50000,ErrorMessage ="Field size has to be in the range of 0 - 50000")]
        public int FieldSize { get; set; }

        [Range(-180, 180, ErrorMessage = "Latitude must be within -90 and 90; Longitude must be within -180 and 180")]
        public float Latitude1 { get; set; }
		public float Latitude2 { get; set; }
		public float Latitude3 { get; set; }
		public float Latitude4 { get; set; }

        public float Longitude1 { get; set; }
        public float Longitude2 { get; set; }
        public float Longitude3 { get; set; }   
        public float Longitude4 { get; set; }



		[ForeignKey("UserID")]
		public string UserID { get; set; }
		
		
        // might need to keep an eye on this line above (if you get an error for trying to access data from an empty table it may be this)

	}
}
