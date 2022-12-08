using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class IndicatorNumber
    {
        private string _key;
        public IndicatorNumber(string key)
        {
            if (_key.Length != 10)
            {
                throw new ArgumentException("Key must be 10 numbers long!");
            }
            bool isNumbers = long.TryParse(key, out long parsedNumber);
            if (!isNumbers)
            {
                throw new ArgumentException("Key must be 10 numbers long!");
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
