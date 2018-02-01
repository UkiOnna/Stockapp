using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public TypeItem Type { get; set; }

        public override string ToString()
        {
            return String.Format("{0}  Имя - {1}  Количество - {2}",Type,Name,Count);
        }
    }
}
