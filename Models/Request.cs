using System.ComponentModel.DataAnnotations;
    
namespace epcdhackthon.Models;

public class Request
{
 
    
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public string FullNameInArabic { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public string FullNameInEnglish { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public string PhoneNumber { get; set; }
    
    [Required(ErrorMessage = "Required")]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public string Nationality { get; set; }
    
    
    [Required(ErrorMessage = "Required")]
    [RegularExpression(@"(^(?i:([a-z])(?!\1{2,}))*$)|(^[A-Ya-y1-8]*$)", ErrorMessage = "You can not have that")]
    public DateOnly? DateOfBirth { get; set; }
   
    [Required(ErrorMessage = "Required")]
    public string IdeaName { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public string IdeaDescription { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public string TeamName { get; set; }
    
    [Required(ErrorMessage = "Required")]
    public DateTime CreationDate { get; set; } = DateTime.Now;

}