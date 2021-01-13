using System;
using System.Collections.Generic;
using System.Text;

namespace Boxes
{
    class Rarity
    {
        public string RarityName { get; set; }

        public int MaxRarityValue { get; set; }

        public int MinRarityValue { get; set; }

        public Rarity(string name, int min, int max)
        {
            RarityName = name;
            MinRarityValue = min;
            MaxRarityValue = max;
        }

    }
}
