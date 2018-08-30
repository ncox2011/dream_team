namespace dreamteam
{
    public class Student
    {
        protected string _firstName {get; set;}
        protected string _lastName {get; set;}
        public string Name { get => $"{_firstName} {_lastName}";}
        public string Specialty {get; set;}
        public string Message {get; set;}
        public string Work()
        {
            return $"{Name} uses {Specialty} to {Message}";
        }
        
    }
}