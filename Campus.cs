using Campus.enums;
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
        private List<Room> _rooms = new List<Room>(10);      
        private List<Worker> _workers = new List<Worker>(10);    
        private Dictionary<IndecatorBook, Student> _students;
        private decimal _revenuePerMonth;
        private Dictionary<int, List<Student>> roomStudents = new Dictionary<int, List<Student>>(10);
        private Campus(string universityName, string adress, List<Room> rooms, List<Worker> workers, Dictionary<IndecatorBook, Student> students, decimal revenuePerMonth, Dictionary<int, List<Student>> roomStudents) // Constructor to clone
        {
            _universityName = universityName;
            _adress = adress;
            _rooms = rooms;
            _workers = workers;
            _students = students;
            _revenuePerMonth = revenuePerMonth;
        }
        public Campus(Worker[] workers, Room[] rooms)
        {
            CampusValidator(rooms, workers);
        }


            

        public string UniversityName { get => _universityName; set => _universityName = value;  }
        public string UniversityAdress { get => _adress; set => _adress = value; }
        public int AmoontOfRooms { get => _rooms.Count; }
        public int AmountOfPersonal { get => _workers.Count; }
        public int AmountOfStudents { get => _students.Count;  }
        public decimal RevenuePerMonth { get => _revenuePerMonth; set => _revenuePerMonth = value; }
        private void CampusValidator(Room[] rooms, Worker[] workers)
        {
            bool result = rooms.Length >= 30;
            result = workers.Length >= 10;
            if(result == false)
            {
                throw new ArgumentException("Incorrent amount of rooms / workers");
            }
            bool[] allPositionsExist = {false, false, false, false};
            Position[] positions = { Position.zavgosp, Position.guardian, Position.commandant, Position.cleaner };
            for (int i = 0; i < positions.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < workers.Length; j++)
                {
                    if(positions[i] == workers[j].Position)
                    {
                        found = true;
                        break;
                   } 
                }
                allPositionsExist[i] = found;
            }
            for (int i = 0; i < allPositionsExist.Length; i++)
            {
                if(allPositionsExist[i] == false)
                {
                    throw new ArgumentException("Not every position was found in workers");               
                }
            }

    
        }
        public void AddRooms(uint amountToAdd)
        {
            Random random = new Random();
            for (int i = 0; i < amountToAdd; i++)
            {
                _rooms.Add(new Room(random.Next(200, 500)));
            }         
        }
        public void SettlementOfStudent(Student student, int roomNumber)
        {
             if(student == null)
            {
                throw new NullReferenceException("student was null");
            }
            if (roomStudents.ContainsKey(roomNumber))
            {
                List<Student> studentsLivingInCurrentRoom = roomStudents[roomNumber];
                foreach (var studentRoom in studentsLivingInCurrentRoom)
                {
                    if(studentRoom.Gender != student.Gender)
                    {
                        throw new ArgumentException("Peope with two different genders cant live in the same room");
                    }
                }
                roomStudents[roomNumber].Add(student);
            }
            roomStudents.Add(roomNumber, new List<Student>() { student });
            _students.Add(student.Key, student);
        }
        public void EvictionOfStudent(IndecatorBook indecatorBook, int roomNumber)
        {
            if (!_students.ContainsKey(indecatorBook))
            {
                throw new ArgumentException("Key (book) was invalid");
            }
            _students.Remove(indecatorBook);
            foreach (var studentInRoom in roomStudents[roomNumber])
            {
                if(studentInRoom.Key == indecatorBook)
                {
                    roomStudents[roomNumber].Remove(studentInRoom);
                    break;
                }
            }
        }
        public void MoveStudent(IndecatorBook indecatorBook, int roomNumberFromWhich, int roomNumberToWhich)
        {
            if (roomStudents.ContainsKey(roomNumberFromWhich) || roomStudents.ContainsKey(roomNumberToWhich))
            {
                throw new ArgumentException("One of the rooms doesnt exist!");
            }
            
            Student savedStudent = null;
            foreach(var student in roomStudents[roomNumberFromWhich])
            {
                if(student.Key == indecatorBook)
                {
                    savedStudent = student;
                  
                    break;
                }
            }
            if (savedStudent == null)
            {
                throw new ArgumentException($"Student with this key wasnt found in {roomNumberFromWhich} room");
            }
            foreach (var studentsInRoom in roomStudents[roomNumberToWhich])                                         //Proverka na gender
            {
                if(studentsInRoom.Gender != savedStudent.Gender)
                {
                    throw new ArgumentException("You cant move to that room due to gender difference");
                }
                break;
            }
            roomStudents[roomNumberFromWhich].Remove(savedStudent);
            roomStudents[roomNumberToWhich].Add(savedStudent);
            
        }
        public void AddWorkers(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _workers.Add(new Worker("Test", "Lecturer"));
            } 
        }
        public override string ToString()
        {
            string result = $"University Name: {_universityName}\nAdress: {_adress}\n" +
                $"Amount of rooms: {_rooms.Count}\nAmount of students: {_students.Count}\n" +
                $"Amount of personal: {_workers.Count}\nRevenue: {_revenuePerMonth}";
            return result;
        }
        public object Clone()
        {
            return new Campus(_universityName, _adress, _rooms, _workers, _students, _revenuePerMonth, roomStudents);
        }
        public decimal CalculateRevenue(PeriodType periodType)
        {
            return _revenuePerMonth * (int)periodType;
        }
    }
}
