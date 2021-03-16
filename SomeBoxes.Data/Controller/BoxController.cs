using SomeBoxes.Model;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace SomeBoxes.Data.Controller
{
    public class BoxController
    {
        public BoxDBContext db = new BoxDBContext();
        public List<Box> GetAllBoxes()
        {
            return db.Box.ToList();
        }

        public List<BoxReady> GetAllReadyBoxes()
        {
            return db.BoxReady.ToList();
        }

        public void RearrangeBox(Box b)
        {
            var parts = PopulateParts(b.WEIGHT, b.PART_COUNT);

            for (int i = 0; i < parts.Count(); i++)
            {
                var boxPart = new BoxReady();
                boxPart.BOX_ID = b.BOX_ID;
                boxPart.PART_NUMBER = i + 1;
                boxPart.PART_WEIGHT = parts[i];
                boxPart.PART_COST = CalculateCost(boxPart.PART_WEIGHT);

                db.BoxReady.Add(boxPart);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Her parçanın ağırlığını hesaplar
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="part_counts"></param>
        /// <returns></returns>
        private List<decimal> PopulateParts(decimal weight, int part_counts)
        {
            var result = new List<decimal>();

            if ((weight/ part_counts) % 2 == 0)
            {
                var cnt = weight / part_counts;
                
                for (int i = 0; i < part_counts; i++)
                {
                    result.Add(cnt);
                }
            }
            else
            {
                var cnt = (weight-1) / part_counts;

                for (int i = 0; i < part_counts; i++)
                {
                    if (i == (part_counts - 1))
                        cnt++;

                    result.Add(cnt);
                }
            }

            return result;
        }

        public decimal CalculateCost(decimal weight)
        {
            return 50 + (weight * 7);
        }
    }
}
