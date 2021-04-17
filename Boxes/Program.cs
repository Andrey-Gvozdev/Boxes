using System;
using System.Collections.Generic;


namespace Boxes
{
    class Program
    {
        public const int BOXCAPACITY = 5;

        static void Main(string[] args)
        {
            var common = new Rarity("common", 1, 140);
            var rare = new Rarity("rare", 141, 188);
            var mystical = new Rarity("mystical", 189, 199);
            var legendary = new Rarity("legendary", 200, 200);

            //var RarityList = new List<Rarity>
            //{
            //    common,
            //    rare,
            //    mystical,
            //    legendary
            //};

            var CommonObjectsList = new List<DropObject> 
            { 
                new DropObject(common, 11),
                new DropObject(common, 12),
                new DropObject(common, 13),
                new DropObject(common, 14),
                new DropObject(common, 15),
                new DropObject(common, 16),
                new DropObject(common, 17),
                new DropObject(common, 18)
            };
            var RareObjectsList = new List<DropObject> 
            {
                new DropObject(rare, 21),
                new DropObject(rare, 22),
                new DropObject(rare, 23),
                new DropObject(rare, 24),
                new DropObject(rare, 25),
                new DropObject(rare, 26)
            };
            var MysticalObjectsList = new List<DropObject> 
            {
                new DropObject(mystical, 31),
                new DropObject(mystical, 32),
                new DropObject(mystical, 33),
                new DropObject(mystical, 34),
                new DropObject(mystical, 35)
            };
            var LegendaryObjectsList = new List<DropObject> 
            {
                new DropObject(legendary, 41),
                new DropObject(legendary, 42),
                new DropObject(legendary, 43)
            };

            var CaseList = new List<DropObject> { };

            while (true)
            {
                Console.WriteLine("Press anything to Start");
                Console.ReadKey();

                Random rand = new Random();
                for (int i = 0; i < BOXCAPACITY; i++)
                {
                    int temp = rand.Next(1, 200);
                    while (true)
                    {
                        if (temp >= common.MinRarityValue && temp <= common.MaxRarityValue)
                        {
                            AddItem(CommonObjectsList);
                            break;
                        }
                        if (temp >= rare.MinRarityValue && temp <= rare.MaxRarityValue)
                        {
                            AddItem(RareObjectsList);
                            break;
                        }
                        if (temp >= mystical.MinRarityValue && temp <= mystical.MaxRarityValue)
                        {
                            AddItem(MysticalObjectsList);
                            break;
                        }
                        if (temp >= legendary.MinRarityValue && temp <= legendary.MaxRarityValue)
                        {
                            AddItem(LegendaryObjectsList);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Exception!");
                            break;
                        }
                    }
                }

                Console.WriteLine("#####################");

                foreach (var item in CaseList)
                {
                    Console.WriteLine(item.Content);
                }

                CaseList.Clear();
            }


            void AddItem(List<DropObject> rarityObjectsList)
            {
                Random rand = new Random();
                int temp = rand.Next(1, rarityObjectsList.Count);
                CaseList.Add(rarityObjectsList[temp]);
            }
            
        }

    }
}
