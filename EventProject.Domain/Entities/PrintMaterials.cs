using System;
using System.Collections.Generic;
using System.Linq;
namespace EventProject.Domain.Entities
{
    public class PrintMaterials
    {
        public int Id { get; set; }

        public required string PrintingHouseName { get; set; }

        public string? ContactName { get; set; }
        /// <summary>
        /// The name of the person who released the materials for printing
        /// </summary>
        public required string Name { get; set; }

        public required DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
