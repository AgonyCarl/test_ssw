using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_ssw
{
    public class Product
    {
        private String name;
        private String code;
        private String size;
        private int number;

        public Product()
        {

        }

        public Product(string name, string code, string size, int number)
        {
            this.name = name;
            this.code = code;
            this.size = size;
            this.number = number;
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string Size { get => size; set => size = value; }
        public int Number { get => number; set => number = value; }
    }
}
