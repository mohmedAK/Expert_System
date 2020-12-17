using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazin_Project
{
    class config
    {
        public static string DatabaseFile = @".\myDB.db";
        public static string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }
    }
}
