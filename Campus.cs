using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class Campus : ICloneable
    {
        private string _universityName;
        private string _adress;
        private uint _amoutOfRooms;
        private uint _amountOfPersonal;
        private uint _amountOfStudents;
        private decimal _revenuePerMonth;
        public Campus(string universityName, string adress, uint amountOfRooms, uint amountOfPersonal, uint amountOfStudents, decimal revenue)
        {
            _universityName = universityName;
            _adress = adress;
            _amoutOfRooms = amountOfRooms;
            _amountOfPersonal = amountOfPersonal;
            _amountOfStudents = amountOfStudents;
            _revenuePerMonth = revenue;
        }
        public string UniversityName { get => _universityName; set => _universityName = value;  }
        public string UniversityAdress { get => _adress; set => _adress = value; }
        public uint AmoontOfRooms { get => _amoutOfRooms; set => _amoutOfRooms = value; }
        public uint AmountOfPersonal { get => _amountOfPersonal; set => _amountOfPersonal = value; }
        public uint AmountOfStudents { get => _amountOfStudents; set => _amountOfStudents = value; }
        public decimal RevenuePerMonth { get => _revenuePerMonth; set => _revenuePerMonth = value; }
        public void AddRooms(uint amountToAdd)
        {
            _amoutOfRooms += amountToAdd;
        }
        public void SettlementOrEvictionOfStudents(uint amount, bool amountIsIncreasing = true)
        {
            if (amountIsIncreasing)
            {
                _amountOfStudents += amount;
                return;
            }
            if(amount > _amountOfStudents)
            {
                throw new ArgumentException("Amount of students that are getting out cant be more than live in Campus!");
            }
           _amountOfStudents -= amount;
        }
        public override string ToString()
        {
            string result = $"University Name: {_universityName}\nAdress: {_adress}\n" +
                $"Amount of rooms: {_amoutOfRooms}\nAmount of students: {_amountOfStudents}\n" +
                $"Amount of personal: {_amountOfPersonal}\nRevenue: {_revenuePerMonth}";
            return result;
        }
        public object Clone()
        {
            return new Campus(_universityName, _adress, _amoutOfRooms, _amountOfPersonal, _amountOfStudents, _revenuePerMonth);
        }
        public decimal CalculateRevenue(PeriodType periodType)
        {
            return _revenuePerMonth * (int)periodType;
        }
    }
}
