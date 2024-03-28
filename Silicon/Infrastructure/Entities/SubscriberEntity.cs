﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class SubscriberEntity
{
    [Key]
    public string Email { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
