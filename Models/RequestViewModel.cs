using System.ComponentModel.DataAnnotations;

namespace epcdhackthon.Models;

public class RequestViewModel
{
    public int Id { get; set; }
    
    [Required (ErrorMessage = "enter fucler")]
    public string FullNameInArabic { get; set; }
    
    [Required]
    public string FullNameInEnglish { get; set; }
    public string PhoneNumber { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public string Nationality { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string IdeaName { get; set; }
    public string IdeaDescription { get; set; }
    public string TeamName { get; set; }
    public string Attachments { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;

}