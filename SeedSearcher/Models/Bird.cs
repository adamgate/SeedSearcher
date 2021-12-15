using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeedSearcher.Models
{
    public class Bird
    {
        [Key]
        public int BirdId { get; set; }

        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Habitat { get; set; }
        public string Location { get; set; }
        public string blurb { get; set; }

        public byte[] image { get; set; }
    }
}
