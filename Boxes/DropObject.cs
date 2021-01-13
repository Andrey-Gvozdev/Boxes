using System;
using System.Collections.Generic;
using System.Text;

namespace Boxes
{
    class DropObject
    {
        public Rarity RarityObject { get; set; }

        public int Content { get; set; }

        public DropObject(Rarity rarity, int content)
        {
            RarityObject = rarity;
            Content = content;
        }

    }
}
