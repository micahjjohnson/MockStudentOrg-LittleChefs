using System;

namespace LittleChefs
{
    public class Item
    {
        private Section s;

        public Item(Section s)
        {
            this.s = s;
        }

        internal decimal getPrice()
        {
            throw new NotImplementedException();
        }

        public Section getSection()
        {
            return s;
        }
    }
}