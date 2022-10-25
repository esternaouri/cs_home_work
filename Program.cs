using System;
using System.IO;
//Q1: כשמאתחלים אותו עם NEW
//Q2:7
//Q3: מחלקה
//Q4:כדי לממש ולהשתממש במחלקה  וכדי לעדכן נתונים 
//Q5: כשיוצרים כמה בנאים שכל אחד מקבל סוג אחר של פרמטרים

class Program
{
public static void Main(){

    Console.WriteLine("q7 :--------");
    
    Car c1=new Car("Toyota");
    System.Console.WriteLine(c1.GetBrand());

    Console.WriteLine("q8:--------");
    
    ConsolePlus cn1=new ConsolePlus();
    ConsolePlus cn2=new ConsolePlus("Esther");
    ConsolePlus cn3=new ConsolePlus(5,2);
    ConsolePlus cn4=new ConsolePlus(2,8,"Esther");
    
    Console.WriteLine("q9:--------");

    Console.WriteLine("How many person you need to update?");

     string n = Console.ReadLine();
     Console.WriteLine("We will update: "+n+" new Persons.");
     
     int num = Int16.Parse(n);

      Person[] arrayOfPerson = new Person[num];
      Person[] arrayOfPerson2 = new Person[num];

      string[] arrayOfNames = new string[num];
      int[] arrayOfAges = new int[num];

         for(int i=0; i<arrayOfPerson.Length ;i++)
         {
           arrayOfPerson[i] = new Person("Esther"+i);
           arrayOfNames[i] = arrayOfPerson[i].GetName();
         }

         for(int j=0;  j < arrayOfNames.Length ; j++)
         {
           Console.WriteLine(arrayOfNames[j]);
         }
  
            Console.WriteLine("q9 -final exercise-------");
   
         for(int x=0; x < arrayOfAges.Length ; x++)
         {
            Random rand = new Random();
            int number = rand.Next(0, 100); 

            arrayOfPerson2[x] = new Person("Esther"+x , number);
            arrayOfAges[x] = arrayOfPerson2[x].GetAge();
            arrayOfNames[x] = arrayOfPerson2[x].GetName();

            Console.WriteLine("Name: " + arrayOfNames[x]+"," + " Age: " + arrayOfAges[x] );

         }
}
}
