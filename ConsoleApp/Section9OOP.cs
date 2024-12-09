namespace ConsoleApp;

public class Section9OOP
{

    public struct Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public static Person createPerson()
    {
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        string parsedName = !string.IsNullOrEmpty(name) ? name : "";
        
        Console.WriteLine("Enter your age: ");
        int parsedAge = int.TryParse(Console.ReadLine(), out int age) ? age : 0;
        
        return new Person(parsedName, parsedAge);
    }
    public static void Struct()
    {
        Person person = createPerson();
        Console.WriteLine("{0} - {1}", person.name, person.age);
    }

    public struct Box
    {
        public int length;
        public int width;
        public int height;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
    }

    public static Box createBox()
    {
        Console.Write("Enter your length: ");
        var lengthVar = Console.ReadLine();
        Console.Write("Enter your width: ");
        var widthVar = Console.ReadLine();
        Console.Write("Enter your height: ");
        var heightVar = Console.ReadLine();
        try
        {
            int length = int.Parse(lengthVar);
            int width = int.Parse(widthVar);
            int height = int.Parse(heightVar);
            return new Box(length, width, height);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public static void BoxStructure()
    {
        Box box = createBox();
        Console.WriteLine("{0} - {1} - {2}", box.width, box.length, box.height);
    }

    public class BoxClass
    {
        public int length;
        public int width;
        public int height;

        public BoxClass(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public BoxClass(int length)
        {
            this.length = length;
            this.width = length;
            this.height = length;
        }

        public string PrintDetails()
        {
            return $"Length: {length}\nWidth: {width}\nHeight:{height}";
        }
    }

    public static void Classes()
    {
        BoxClass box = new BoxClass(1);
        Console.WriteLine("{0} - {1} - {2}", box.length, box.width, box.height);
    }

    public static int ReadValue(string key)
    {
        Console.Write("Type {0}: ", key);
        return int.TryParse(Console.ReadLine(), out int value) ? value : -1;
    }

    public static BoxClass createClassBox()
    {
        return new BoxClass(ReadValue("length"), ReadValue("width"), ReadValue("height"));
    }

    public static void JustPlaying()
    {
        BoxClass box = createClassBox();
        Console.WriteLine(box.PrintDetails());
    }

    public class Car
    {
        private string model;
        private string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
        
        public string Model
        {
            get => string.IsNullOrEmpty(model) ? "No model" : model;
            set => model = !string.IsNullOrEmpty(value) ? value : String.Empty;
        }

        public string Color
        {
            get => string.IsNullOrEmpty(color) ? "No color" : color;
            set => color = !string.IsNullOrEmpty(value) ? value : String.Empty;
        }
    }

    public static void Fields()
    {
        Car car = new Car("", "");
        Console.WriteLine("{0} - {1}", car.Model, car.Color);
        car.Model = "Mercedes";
        car.Color = "Red";
        Console.WriteLine("{0} - {1}", car.Model, car.Color);
    }

    class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static bool operator ==(Worker first, Worker second)
        {
            return first.Name.Equals(second.Name) && first.Age.Equals(second.Age);
        }
        
        public static bool operator !=(Worker first, Worker second)
        {
            return !first.Name.Equals(second.Name) || first.Age.Equals(second.Age);
        }

        public bool Equals(object obj)
        {
            if (obj is Worker)
            {
                Worker worker = obj as Worker;
                return this == worker;
            }
            return false;
        }
    }

    public static void Overriding()
    {
        Worker workerOne = new Worker();
        workerOne.Age = 4;
        workerOne.Name = "James";
        Worker workerTwo = new Worker();
        workerTwo.Age = 4;
        workerTwo.Name = "James";
        Console.WriteLine("{0} == {1}, {2}", workerOne.Name, workerTwo.Name, workerOne.Equals(workerTwo));
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\t Age: {Age}";
        }
    }

    class Student : Human
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade) : base(name, age)
        {
            this.Grade = grade;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}\tGrade: {Grade}";
        }
    }
    
    public static void Inheritance()
    {
        Human human = new Human("James", 29);
        Console.WriteLine(human.ToString());

        Student student = new Student("James", 29, 5);
        Console.WriteLine(student.ToString());
    }
    
}