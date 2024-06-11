﻿using PlantCare.Web.Models.Abstractions;

namespace PlantCare.Web.Models
{
    public class Reminder : DictionaryModel
    {
        public int PlantId { get; set; }
        public DateTime ReminderDate { get; set; }
        public bool IsCompleted { get; set; }
        public Plant Plant { get; set; }
    }
}