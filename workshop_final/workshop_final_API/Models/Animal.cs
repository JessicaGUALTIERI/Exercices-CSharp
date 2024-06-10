using System;
namespace workshop_final_API.Models
{
	public class Animal
	{
        public int Id { get; set; }
        public int SpecieId { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
    }
}

