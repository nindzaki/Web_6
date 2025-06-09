using System.ComponentModel.DataAnnotations;

public class Transistor : RadioProduct
{
    [Display(Name = "Тип")]
    public string Type { get; set; } = string.Empty;

    [Display(Name = "Номер")]
    public string Number { get; set; } = string.Empty;
}