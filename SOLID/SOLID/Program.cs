using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single responsibility

            //Student s1 = new Student("Emil Kerimov");
            //s1.GroupName = "P620";
            //s1.GroupType = "Programming";

            //Student s2 = new Student("Emil Kerimov");
            //s1.GroupName = "P620";
            //s1.GroupType = "Programming";

            //Student s3 = new Student("Emil Kerimov");
            //s1.GroupName = "P620";
            //s1.GroupType = "Programming";

            //Student s4 = new Student("Emil Kerimov");
            //s1.GroupName = "P620";
            //s1.GroupType = "Programming";

            //Group g1 = new Group { GroupName = "P320", GroupType = "Programming" };
            //Student s1 = new Student("Emil Kerimov")
            //{
            //    Group = g1
            //};

            #endregion

            #region Open/Closed principle

            //Rectangle r1 = new Rectangle { Length = 10, Width = 5 };
            //Square s1 = new Square { Length = 10 };
            //GetArea(r1, s1);

            #endregion

            #region Liskov substituation

            //Apple apple = new Orange();

            #endregion

            #region Dependency Inversion

            //Controller c1 = new Controller(new Database());
            Controller c1 = new Controller(new FileStore());

            #endregion
        }

        static void GetArea(params IFigure[] figures)
        {
            foreach (var item in figures)
            {
                Console.WriteLine(item.GetArea());
            }
        }

        //static void GetArea(params object[] figures)
        //{
        //    foreach (var item in figures)
        //    {
        //        if (item is Rectangle rectangle)
        //        {
        //            Console.WriteLine(rectangle.GetArea());
        //        }
        //        else if (item is Square square)
        //        {
        //            Console.WriteLine(square.GetArea());
        //        }
        //    }
        //}
    }

    #region Single responsibility

    class Group
    {
        public string GroupName { get; set; }

        public string GroupType { get; set; }
    }

    class Student
    {
        public string Fullname { get; set; }

        public Group Group { get; set; }

        public Student(string fullName)
        {
            Fullname = fullName;
        }
    }

    #endregion

    #region Open/Closed principle
    //open to extend, close to modify

    interface IFigure
    {
        int GetArea();
    }

    class Square : IFigure
    {
        public int Length { get; set; }

        public int GetArea()
        {
            return Length * Length;
        }
    }

    class Rectangle : IFigure
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int GetArea()
        {
            return Length * Width;
        }
    }

    #endregion

    #region Liskov substituation

    abstract class Fruit
    {

    }

    class Apple : Fruit
    {

    }

    class Orange : Fruit
    {

    }

    #endregion

    #region Interface segregation

    interface ICalculator
    {
        int Sum();
        int Difference();
        int Multiply();
        int Divide();
    }

    interface ISum
    {
        int Sum();
    }

    class Sum2 : ISum
    {
        public int Sum()
        {
            throw new NotImplementedException();
        }
    }

    class Calculator : ICalculator
    {
        public int Difference()
        {
            throw new NotImplementedException();
        }

        public int Divide()
        {
            throw new NotImplementedException();
        }

        public int Multiply()
        {
            throw new NotImplementedException();
        }

        public int Sum()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Dependency inversion

    interface IStore
    {
        void GetData();
    }

    class Database : IStore
    {
        public void GetData()
        {

        }
    }

    class FileStore : IStore
    {
        public void GetData()
        {

        }
    }

    class Controller
    {
        public Controller(IStore store)
        {
            //Database database = new Database();
            //database.GetData();
            //FileStore fileStore = new FileStore();
            //fileStore.GetData();
            store.GetData();
        }
    }

    #endregion
}
