using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnPropertiesAndIndexers
{
    class RangeOfArray
    {
        private int[] array;

        public RangeOfArray(int loverRange, int upRange)
        {
            if (loverRange > upRange)
            {
                Swap(ref loverRange, ref upRange);
            }

            LoverRange = loverRange;
            UpRange = upRange;
            array = new int[upRange - loverRange];
        }

        /*Метод метод обмена значениями полей*/
        public void Swap(ref int value1, ref int value2)
        {
            int tmp = value1;
            value1 = value2;
            value2 = tmp;
        }

        public int LoverRange { get; set; }
        public int UpRange { get; set; }

        public int this[int index]
        {
            get
            {
                if (LoverRange > 0)
                    return array[Math.Abs(index) - LoverRange];
                else
                    return array[Math.Abs(LoverRange) + index];
            }
            set
            {
                if (LoverRange > 0)
                    array[Math.Abs(index) - LoverRange] = value;
                else
                    array[Math.Abs(LoverRange) + index] = value;
            }
        }

        public void ShowClassArray()
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
      
    }
}
