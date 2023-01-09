using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace TwitterAPIStreamApp.Models
{
    public class Tweet
    {
        [Key]
        [Required]
        public long id { get; set; }
        [JsonIgnore]
        public virtual List<public_metrics>? Public_metrics { get; set; }
        [Required]
        public long public_metricsid { get; set; }
        
        public virtual public_metrics? Public_metrics1 { get; set; }
    }
}
