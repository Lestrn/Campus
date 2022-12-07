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
        private string _universityAdress;
        private uint _amoutOfRooms;
        private int _amountOfPersonal;
        private int _amountOfStudents;
        private decimal _revenuePerMonth;
        public Campus(string universityName, string universityAdress, uint amoontOfRooms, int amountOfPersonal, int amountOfStudents, decimal revenue)
        {
            _universityName = universityName;
            _universityAdress = universityAdress;
            _amoutOfRooms = amoontOfRooms;
            _amountOfPersonal = amountOfPersonal;
            _amountOfStudents = amountOfStudents;
            _revenuePerMonth = revenue;
        }
        public string UniversityName { get => _universityName; set => _universityName = value;  }
        public string UniversityAdress { get => _universityAdress; set => _universityAdress = value; }
        public uint AmoontOfRooms { get => _amoutOfRooms; set => _amoutOfRooms = value; }
        public int AmountOfPersonal { get => _amountOfPersonal; set => _amountOfPersonal = value; }
        public int AmountOfStudents { get => _amountOfStudents; set => _amountOfStudents = value; }
        public decimal RevenuePerMonth { get => _revenuePerMonth; set => _revenuePerMonth = value; }
        public void AddRooms(uint amountToAdd)
        {
            _amoutOfRooms += amountToAdd;
        }
        public void SettlementOrEvictionOfStudents(int amount, bool amountIsIncreasing = true)
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
            string result = $"University Name: {_universityName}\nAdress: {_universityAdress}\n" +
                $"Amount of rooms: {_amoutOfRooms}\nAmount of students: {_amountOfStudents}\n" +
                $"Amount of personal: {_amountOfPersonal}\nRevenue: {_revenuePerMonth}";
            return result;
        }
        public object Clone()
        {
            return new Campus(_universityName, _universityAdress, _amoutOfRooms, _amountOfPersonal, _amountOfStudents, _revenuePerMonth);
        }
        public decimal CalculateRevenue(PeriodType periodType)
        {
            return _revenuePerMonth * (int)periodType;
        }
    }
}
