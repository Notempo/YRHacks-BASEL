using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Yrhacks2023.Shared;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public int Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Seller { get; set; } = string.Empty;
    
    [NotMapped]
    [JsonIgnore]
    public ItemType ItemType
    {
        get => (ItemType) Type;
        set => Type = (int) value;
    }
}