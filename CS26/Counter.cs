using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS26
{
    public class Counter
    {
        private int _count = 0;

        public Counter(int count)
        {
            SetCount();
        }

        public void Call()
        {
            _count++;
        };

        public void SetCount(int value)
        {
            //ここに処理が書ける
            if(value >= 100)
            {
                _count = 100;
                return;
            }
            _count = value;
        }

    }
}
