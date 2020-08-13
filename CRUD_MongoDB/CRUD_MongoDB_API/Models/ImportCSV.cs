using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CRUD_MongoDB_API.Models
{
    public class ImportCSV
    {
        [BsonElement("_id")]
        [BsonRequired]
        public ObjectId Id { get; set; }

        [BsonElement("Region")]
        [BsonRequired]
        public string Region { get; set; }

        [BsonElement("Country")]
        [BsonRequired]
        public string Country { get; set; }

        [BsonElement("Item Type")]
        [BsonRequired]
        public string ItemType { get; set; }

        [BsonElement("Sales Channel")]
        [BsonRequired]
        public string SalesChannel { get; set; }

        [BsonElement("Order Priority")]
        [BsonRequired]
        public string OrderPriority { get; set; }

        [BsonElement("Order Date")]
        [BsonRequired]
        public DateTime OrderDate { get; set; }

        [BsonElement("Order ID")]
        [BsonRequired]
        public string OrderId { get; set; }

        [BsonElement("Ship Date")]
        [BsonRequired]
        public DateTime ShipDate { get; set; }

        [BsonElement("Units Sold")]
        [BsonRequired]
        public int UnitsSold { get; set; }

        [BsonElement("Unit Price")]
        [BsonRequired]
        public decimal UnitPrice { get; set; }

        [BsonElement("Unit Cost")]
        [BsonRequired]
        public decimal UnitCost { get; set; }

        [BsonElement("Total Revenue")]
        [BsonRequired]
        public decimal TotalRevenue { get; set; }

        [BsonElement("Total Cost")]
        [BsonRequired]
        public decimal TotalCost { get; set; }

        [BsonElement("Total Profit")]
        [BsonRequired]
        public decimal TotalProfit { get; set; }
    }
}
