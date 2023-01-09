namespace TwitterAPIStreamApp.Models
{
    public class TweetsQueryParameters : QueryParameters
    {
        //public decimal? MinPrice { get; set; }
        //public decimal? MaxPrice { get; set; }

        public string HashTags { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        //public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public int TweetsCount { get; set; }

        public string SearchTerm { get; set; } = string.Empty;
    }
}
