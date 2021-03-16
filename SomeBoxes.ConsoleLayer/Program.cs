using SomeBoxes.Data.Controller;
using System;

namespace SomeBoxes.ConsoleLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BoxController bc = new BoxController();
                var boxes = bc.GetAllBoxes();

                foreach (var item in boxes)
                {
                    bc.RearrangeBox(item);
                    Console.WriteLine("Box_ID : " + item.BOX_ID + " calculated.");
                }

                var box_parts = bc.GetAllReadyBoxes();

                Console.WriteLine("");
                Console.WriteLine("BOX_ID   PART_NUMBER     PART_WEIGHT     PART_COST");
                Console.WriteLine("---------------------------------------------------");

                foreach (var item in box_parts)
                {
                    Console.WriteLine(item.BOX_ID + "   " + item.PART_NUMBER + "    " + item.PART_WEIGHT.ToString("N") + "    " + item.PART_COST.ToString("N"));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata detayı : " + ex.Message);
            }
        }
    }
}
