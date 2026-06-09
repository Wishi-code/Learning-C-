using System;
namespace Level2
{
    class Car/*
    {


        string color = "red";
        string model;
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Sedan";
            Console.WriteLine(myCar.color);
            Console.WriteLine(myCar.model);


            Car myCar2 = new Car();
            Console.WriteLine(myCar2.color);
        }
    }
}*/
    /*  {
          //use of constructor
          public string model;
          // create a constructor.
          public Car(string modelName)
          {
              model = modelName;
          }
          static void Main(string[] args)
          {
              Car myCar = new Car("Sedan");
              Console.WriteLine(myCar.model);
          }
      }

  }*/
    {
        //private 
        public string model = "Sedan";
        
    }

    class Car2
    {
        //public
        public string model = "Sedan";
        static void Main(string[] args)
        {
            Car2 myCar2 = new Car2();
            Console.WriteLine(myCar2.model);
            Console.WriteLine(myCar2.model);


          
            Car myCar = new Car();
            Console.WriteLine(myCar.model);
        
        }
    }
}

