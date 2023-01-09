using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TwitterAPIStreamApp.Models;

namespace TwitterAPIStreamApp.Models
{
    public static class ModelBuilderTweetExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>().HasData(
                new Tweet { id = 1263150595717730305},
                new Tweet { id = 1263150595717730306},
                new Tweet { id = 1263150595717730307},
                new Tweet { id = 1263150595717730308});

            modelBuilder.Entity<public_metrics>().HasData(
                new public_metrics { id = 1263150595717730305, Name = "Person1", retweet_count = 12, reply_count = 14, like_count = 49, quote_count = 7, text = "Do you our new Tweet settings?\n\nWe want to know how and why you’d use a feature like this in the API. Get the details and let us know what you think https://t.co/8wxeZ9fJER" },
                new public_metrics { id = 1263150595717730306, Name = "Person2", retweet_count = 10, reply_count = 20, like_count = 19, quote_count = 4, text = "Do you our new Tweet settings?\n\nWe want to know how and why you’d use a feature like this in the API. No not really but I can use https://t.co/8wxeZ9fJER"},
                new public_metrics { id = 1263150595717730307, Name = "Person3", retweet_count = 4, reply_count = 114, like_count = 78, quote_count = 9, text = "Do you our new Tweet settings?\n\nWe want to know how and why you’d use a feature like this in the API. Yes please use this https://t.co/8wxeZ9fJER" },
                new public_metrics { id = 1263150595717730308, Name = "Person4", retweet_count = 1, reply_count = 143, like_count = 9, quote_count = 17, text = "Do you our new Tweet settings?\n\nWe want to know how and why you’d use a feature like this in the API. Why do I need to use it https://t.co/8wxeZ9fJER" },
                new public_metrics { id = 1263150595717730309, Name = "Person5", retweet_count = 12, reply_count = 60, like_count = 2, quote_count = 79, text = "Do you our new Tweet settings?\n\nWe want to know how and why you’d use a feature like this in the API. No way I need to use it https://t.co/8wxeZ9fJER" });
        }
    }
}
