using System;

namespace Quiz20_Delegates
{
    delegate void MyDel();
    class Program
    {
        public class Rifle
        {
            public static void Shoot()
            {
                Console.WriteLine("I am a Rifle and I go Bang.");
            }
        }
        public class Shotgun
        {
            public static void Shoot()
            {
                Console.WriteLine("I am a Shotgun and I go Boom.");
            }
        }
        public class Pistol
        {
            public static void Shoot()
            {
                Console.WriteLine($"I am a Pistol and I go Pop.");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("This is C# chapter 20 quiz");
            MyDel del1, del2, del3, del4;
            del1 = Rifle.Shoot;
            del2 = Shotgun.Shoot;
            del3 = Pistol.Shoot;

            del4 = del1 + del2 + del3;

            del4();
        }
    }
}

//Shoot del = r.Speak;
//del += p.Speak;
//speak method
//void method that print I am a X and I go Y.
//I am a shotgun and I go Boom
//I am a rifle and I go Bang
//I am a pistol and I go Pop

//Quiz 20 — Delegates
//C# Programming
//This is a timed test. You have thirty minutes to complete the test. When you finish the test, upload your
//Program.cs to Canvas. Do not publish your answer to your git repository.
//Create a console application. Create three classes, a Rifle class, a Pistol class, and a Shotgun class. In each
//class, create one method, a void method that takes no parameters, and prints a message to console similar to this:
//“I am a X and I go Y.” Repplace X and Y with the appropriate values. Create a delegate of the appropriate type.
//Instantiate three objects and assign to the delegate the three methods.Call the delegate. Note that one call to the
//delegate invokes three methods.Your output should be similar to that shown below.
//Here is the expected output.
//This is C Sharp quiz 20
//I am a shotgun and I go Boom
//I am a rifle and I go Bang
//I am a pistol and I go Pop
//Press any key to continue . . .
