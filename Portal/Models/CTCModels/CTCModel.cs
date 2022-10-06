using System.ComponentModel.DataAnnotations;

namespace Portal.Models.CTCModels;

public class CTCModel
{
    [Required]
    public string text { get; set; }
}