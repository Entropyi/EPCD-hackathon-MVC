using System.ComponentModel.DataAnnotations;

namespace epcdhackthon.Models;

public class Request
{
    public int Id { get; set; }
    
    [Required]
    public string FullNameInArabic { get; set; }
    
    [Required]
    public string FullNameInEnglish { get; set; }
    
    [Required]
    public string PhoneNumber { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Nationality { get; set; }
    
    
    [Required]
    public DateTime DateOfBirth { get; set; }
   
    [Required]
    public string IdeaName { get; set; }
    
    [Required]
    public string IdeaDescription { get; set; }
    
    [Required]
    public string TeamName { get; set; }
    
    [Required]
    public DateTime CreationDate { get; set; } = DateTime.Now;

}