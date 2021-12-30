using System.Text.Json.Serialization;

namespace RazorPdfDemo.Models
{
    public partial class Product
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("supplierId")]
        public int? SupplierId { get; set; }
        [JsonPropertyName("categoryId")]
        public int? CategoryId { get; set; }
        [JsonPropertyName("quantityPerUnit")]
        public string? QuantityPerUnit { get; set; }
        [JsonPropertyName("unitPrice")]
        public decimal? UnitPrice { get; set; }
        [JsonPropertyName("unitsInStock")]
        public short? UnitsInStock { get; set; }
        [JsonPropertyName("unitsOnOrder")]
        public short? UnitsOnOrder { get; set; }
        [JsonPropertyName("reorderLevel")]
        public short? ReorderLevel { get; set; }
        [JsonPropertyName("discontinued")]
        public bool Discontinued { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }
}