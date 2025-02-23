﻿
using BusinessLogic.Enities;
using System.Text.Json.Serialization;

namespace BusinessLogic.Entities
{
    public class Advert
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        [JsonIgnore]
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
        [JsonIgnore]
        public ICollection<AdvertValue> Values { get; set; } = new HashSet<AdvertValue>();
        [JsonIgnore]
        public ICollection<OrderAdvert> Orders { get; set; } = new HashSet<OrderAdvert>();
    }
}
