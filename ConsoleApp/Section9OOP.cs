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

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public abstract void makeNoise();
    }

    class Dog : Animal
    {
        public string Color { get; set; }
        public Dog(string name, int age, string color) : base(name, age)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nColor: {Color}";
        }

        public override void makeNoise()
        {
            Console.WriteLine("Gaf Gaf");
        }
    }
    public static void Refreshing()
    {
        Dog dog = new Dog("Trisha", 10, "black");
        Console.WriteLine(dog.ToString());
        dog.makeNoise();
    }
    
    interface IAutomobile
    {
        void produceMoto();
    }

    abstract class Automobile : IAutomobile
    {
        public string name { get; set; }
        public int age { get; set; }
        public Automobile(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void produceMoto();
    }

    class Mercedes : Automobile
    {
        public Mercedes(int age) : base("Mercedes", age)
        {
        }

        public override void produceMoto()
        {
            Console.WriteLine("Mercedes is the best car in the world");
        }

        public static Mercedes CreateMercedes()
        {
            int age;
            Console.Write("Type age of the mercedes: ");
            int.TryParse(Console.ReadLine(), out age);
            return new Mercedes(age);
        }
    }

    public static void MercedesBenz()
    {
        Mercedes mercedes = Mercedes.CreateMercedes();
        mercedes.produceMoto();
    }
    
    interface IStudent {
        public string name { get; set; }
        public Score score { get; set; }
    }

    public enum Score
    {
        Invalid,
        A = 1,
        B,
        C, 
        D, 
        E
    }

    public class ActiveStudent: IStudent
    {
        public string name { get; set; }
        public Score score { get; set; }

        public ActiveStudent(string name, Score score)
        {
            this.name = name;
            this.score = score;
        }

        public static ActiveStudent CreateStudent()
        {
            Console.Write("Enter student name: ");
            string nameInput = Console.ReadLine()?.Trim() ?? string.Empty;
            
            Console.Write("Enter score: ");
            if (Enum.TryParse(Console.ReadLine(), out Score score))
            {
                if (Enum.IsDefined(typeof(Score), score))
                { 
                    Console.Write("Valid score");
                }
                else
                {
                    Console.WriteLine("Invalid score");
                }
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
            
            return new ActiveStudent(nameInput, score);
        }
    }

    public static void PracticeEnums()
    {
        ActiveStudent student = ActiveStudent.CreateStudent();
        Console.WriteLine(student.score);
    }

}