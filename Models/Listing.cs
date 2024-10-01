﻿namespace ListingService.Models
{
   
    
        public class Listing
        {
            public int Id { get; set; }  // Primärnyckel (Primary Key)
            public string Title { get; set; }  // Annonsens titel
            public string Description { get; set; }  // Beskrivning av annonsen
            public decimal Price { get; set; }  // Pris på produkten
            public string UserId { get; set; }  // Användar-ID som skapade annonsen
            public DateTime CreatedAt { get; set; } = DateTime.Now;

        }

    
    
}
