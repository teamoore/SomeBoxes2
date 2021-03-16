using System.ComponentModel.DataAnnotations;

namespace SomeBoxes.Model
{
    public class Box
    {
        [Key]
        public int BOX_ID { get; set; }
        public decimal WEIGHT { get; set; }
        public int PART_COUNT { get; set; }
    }
}
