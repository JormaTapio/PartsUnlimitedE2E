using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Category
    {
        //Tapsa's third comment ... or ... 13.5
        //Uusi kommentti kello 19:37 ... miten menee?
        //Category commit always
        //My third change.


        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}