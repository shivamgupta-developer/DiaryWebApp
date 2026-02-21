using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int id {  get; set; }
        [Required]
        public string Title { get; set; }=string.Empty;
        //[Required]
        //[StringLength(100, MinimumLength =5, ErrorMessage ="Content Length should be in between 5 and 100")]
        public string Content { get; set; }=string.Empty;
        [Required(ErrorMessage ="Please Enter Created Date")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
