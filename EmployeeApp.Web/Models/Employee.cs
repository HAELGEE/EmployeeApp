using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace EmployeeApp.Web.Models;

public class Employee
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Du måste ange ett namn")]
    [StringLength(30, MinimumLength = 6, ErrorMessage = "Måste vara minst 6 och max 30")]
    [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Får bara innehålla Bokstäver")]
    [Display(Name = "Namn på anställd", Prompt = "Skriv namnet på personen här...")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Du måste ange ett giltigt Email")]
    [StringLength(30, MinimumLength = 15, ErrorMessage = "Måste vara minst 15 och max 30")]
    [EmailAddress(ErrorMessage = "Det måste vara ett giltigt Email format")]
    [Display(Name = "Den anställdes Email", Prompt = "Skriv personens Email här...")]
    public string? Email { get; set; }
}
