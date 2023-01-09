using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TwitterAPIStreamApp.Models
{
    public class public_metrics
    {

        public long id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public int retweet_count { get; set; }
        public int reply_count { get; set; }
        public int like_count { get; set; }
        public int quote_count { get; set; }
        public string text { get; set; } = string.Empty;
        public virtual List<Tweet>? Tweets { get; set; }

    }
}
