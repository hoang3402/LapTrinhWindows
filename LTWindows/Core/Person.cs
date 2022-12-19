namespace LTWindows.Core
{
    internal class Person
    {
        string _Name;
        uint _Age;
        double _Salary;

        public string Name { get { return _Name; } set { _Name = value; } }
        public uint Age { get { return _Age; } set { _Age = value; } }
        public double Salary { get { return _Salary; } set { _Salary = value; } }

        public Person(string name, uint age, double salary)
        {
            _Name = name;
            _Age = age;
            _Salary = salary;
        }
    }
}
