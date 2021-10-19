using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS27
{
    public class Counter
    {
        //private int _count = 0;

        //これはコンストラクタ（初期化）
        public Counter(int count)
        {
            //valueが100以下なら…みたいな分岐をして_countに新しい値を入れる
            //SetCount(count);
            Count = count;
        }

        //プロパティ
        //public int Count
        //{
        //    get { return _count; }
        //    set 
        //    {
        //        if (value >= 100)
        //        {
        //            _count = 100;
        //            return;
        //        }
        //        _count = value;
        //    }
        //}

        public int Count { get; private set; }

        public void Call()
        {
            Count++;
        }

        //public void SetCount(int value)
        //{
        //    //ここに処理が書ける
        //    if (value >= 100)
        //    {
        //        _count = 100;
        //        return;
        //    }
        //    _count = value;
        //}

        //public int GetCount()
        //{
        //    return _count;
        //}
    }
}
