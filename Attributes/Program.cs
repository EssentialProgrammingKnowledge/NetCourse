using System.ComponentModel.DataAnnotations;

Person person = new()
{
    FirstName = "Tester",
    LastName = ""
};
ValidationContext context = new (person, null, null);
List<ValidationResult> validationResults = new List<ValidationResult>();
bool valid = Validator.TryValidateObject(person, context, validationResults, true);
if (!valid)
{
    foreach (ValidationResult validationResult in validationResults)
    {
        Console.WriteLine("{0}", validationResult.ErrorMessage);
    }
}
Console.ReadKey();


class Person
{
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
    [DataType(DataType.Text)]
    public string LastName { get; set; }
}