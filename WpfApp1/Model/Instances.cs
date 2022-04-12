using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Instances
    {
        private static user4Entities _Db = null;
        public static user4Entities db
        {
            get
            {
                if (_Db == null)
                    _Db = new user4Entities();
                return _Db;
            }
        }
    }
}
