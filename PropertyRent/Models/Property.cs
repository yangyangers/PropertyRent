using System.ComponentModel.DataAnnotations;

namespace PropertyRent.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters")]
        public string Location { get; set; } = "Cebu City";

        [Required(ErrorMessage = "Property type is required")]
        [StringLength(50, ErrorMessage = "Property type cannot exceed 50 characters")]
        public string PropertyType { get; set; }

        [Required(ErrorMessage = "Rental price is required")]
        [Range(1000, 1000000, ErrorMessage = "Price must be between ₱1,000 and ₱1,000,000")]
        public decimal RentalPrice { get; set; }

        [Range(1, 20, ErrorMessage = "Bedrooms must be between 1 and 20")]
        public int Bedrooms { get; set; }

        [Range(1, 20, ErrorMessage = "Bathrooms must be between 1 and 20")]
        public int Bathrooms { get; set; }

        public bool HasParking { get; set; }

        public bool IsFurnished { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(20, ErrorMessage = "Contact number cannot exceed 20 characters")]
        public string ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string ContactEmail { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.Now;

        public bool IsAvailable { get; set; } = true;

        [StringLength(255)]
        public string ImageUrl { get; set; } = "/images/default-property.jpg";
    }
}