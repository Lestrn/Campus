using Campus.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class Room
    {
        private int _number;
        private RoomType _type;
        private decimal _pricePerPeron;
        private int _currentAmountLiving;
        private List<IndecatorBook> _keys;

        public Room(int number, RoomType type, decimal pricePerPeron, int currentAmountLiving, params IndecatorBook[] keys)
        {
            _keys = new List<IndecatorBook>();
            _number = number;
            _type = type;
            _pricePerPeron = pricePerPeron / (int)type;
            _currentAmountLiving = currentAmountLiving;
            for (int i = 0; i < keys.Length; i++)
            {
                _keys.Add(keys[i]);
            }
            
        }

        public int Number { get => _number; set => _number = value; }
        public RoomType Type { get => _type; }
        public decimal PricePerPeron { get => _pricePerPeron; set => _pricePerPeron = value; }
        public int CurrentAmountLiving { get => _currentAmountLiving; set => _currentAmountLiving = value; }
        public List<IndecatorBook> Keys { get => _keys; set => _keys = value; }
    }
}
