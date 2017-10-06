using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private List<int> SquarePosition
        {
            get;set;
        }
        public Player(string input) {
            this.Initialize(input);
        }
        public void Initialize(string inputstring)
        {
            SquarePosition= inputstring.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(item => int.Parse(item))
        .ToList();
        }
    }
}
