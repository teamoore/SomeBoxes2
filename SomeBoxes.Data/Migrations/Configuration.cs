namespace SomeBoxes.Data.Migrations
{
    using SomeBoxes.Model;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SomeBoxes.Data.BoxDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SomeBoxes.Data.BoxDBContext context)
        {
            IList<Box> boxes = new List<Box>();
            boxes.Add(new Box() { WEIGHT = 3, PART_COUNT = 4 });
            boxes.Add(new Box() { WEIGHT = 8, PART_COUNT = 2 });
            boxes.Add(new Box() { WEIGHT = 11, PART_COUNT = 8 });
            boxes.Add(new Box() { WEIGHT = 3, PART_COUNT = 9 });
            boxes.Add(new Box() { WEIGHT = 13, PART_COUNT = 5 });

            context.Box.AddRange(boxes);
            base.Seed(context);
        }
    }
}
