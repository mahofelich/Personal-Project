using System.ComponentModel.DataAnnotations;

namespace PersonalProject.Client.Models
{
    public class StandDataTable
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage ="Ranks are required, if rank is unknown use '?'")]
        public char Power { get; set; }
        [Required(ErrorMessage = "Ranks are required, if rank is unknown use '?'")]
        public char Speed { get; set; }
        [Required(ErrorMessage = "Ranks are required, if rank is unknown use '?'")]
        public char Range { get; set; }
        [Required(ErrorMessage = "Ranks are required, if rank is unknown use '?'")]
        public char Persistence { get; set; }
        [Required(ErrorMessage = "Ranks are required, if rank is unknown use '?'")]
        public char Precision { get; set; }
        [Required(ErrorMessage = "Ranks are required, if rank is unknown use '?'")]
        public char Potential { get; set; }
        public byte[]? Img { get; set; }
        public string? Desc { get; set; }









}
}
