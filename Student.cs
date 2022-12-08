global using Campus.enums;
namespace Campus
{
    public class Student
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _faculty;
        private Gender _gender;
        private string _group;
        private IndecatorBook key;

        public Student(string name, string surname, string patronymic, string faculty, Gender gender, string group, IndecatorBook key)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _faculty = faculty;
            _gender = gender;
            _group = group;
            this.key = key;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Patronymic { get => _patronymic; set => _patronymic = value; }
        public string Faculty { get => _faculty; set => _faculty = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public string Group { get => _group; set => _group = value; }
        public IndecatorBook Key { get => key; }
    }
}
