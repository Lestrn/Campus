using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class IndecatorBook
    {
        private string _key;
        public IndecatorBook(string key)
        {
           if(_key.Length != 8)
            {
                throw new ArgumentException("Key must be 8 charecters long!");
            }
           _key = key;
        }
        public string Key { get => _key; }
        public override string ToString()
        {
            return _key;
        }
    }
}
