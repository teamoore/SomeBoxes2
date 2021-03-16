using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeBoxes.Model
{
    public class BoxReady
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Box")]
        public int BOX_ID { get; set; }

        public Box Box { get; set; }

        public int PART_NUMBER { get; set; }
        public decimal PART_WEIGHT { get; set; }
        public decimal PART_COST { get; set; }
    }
}
