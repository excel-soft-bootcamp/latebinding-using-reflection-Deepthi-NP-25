using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameApp
{
    //Named Constants
    //Constant Value is - int
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");

            string message = string.Format("Enter Your Choice {0}->Basic , {1}->Intermediate ,{2}->Advanced", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);// 1->Basic,2->Intermediate

            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
            Options _choice = (Options)Int32.Parse(Console.ReadLine());
            switch (_choice)
            {
                case Options.BASIC:
                    Console.WriteLine("Basic Level");

                    System.Reflection.Assembly basicLevelLib =
      System.Reflection.Assembly.LoadFile(@"C:\Users\deepthi.np\source\repos\GameApp\GameApp\bin\Debug\netcoreapp3.1\BasicLevelLib.dll");

                    System.Type basicLevelTypeClassRef = basicLevelLib.GetType("BasicLevelLib.BasicLevelType");
                    if (basicLevelTypeClassRef != null)
                    {
                        if (basicLevelTypeClassRef.IsClass)
                        {

                            Object objRef = System.Activator.CreateInstance(basicLevelTypeClassRef);

                            System.Reflection.MethodInfo _methodRef = basicLevelTypeClassRef.GetMethod("Play");
                            if (!_methodRef.IsStatic)
                            {

                                object result = _methodRef.Invoke(objRef, new object[] { });
                                Console.WriteLine(result.ToString());
                            }

                        }

                    }
                    break;
                case Options.INTERMEDIATE:
                    Console.WriteLine("Intermediate Level");
                    System.Reflection.Assembly intermediateLevelLib =
                    System.Reflection.Assembly.LoadFile(@"C:\Users\deepthi.np\source\repos\GameApp\GameApp\bin\Debug\netcoreapp3.1\IntermediateLevelLib.dll");
                    System.Type intermediateTypeClassRef = intermediateLevelLib.GetType("IntermediateLevelLib.IntermediateLevelType");

                    if (intermediateTypeClassRef != null)
                    {
                        if (intermediateTypeClassRef.IsClass)
                        {

                            Object objRef = System.Activator.CreateInstance(intermediateTypeClassRef);
                            System.Reflection.MethodInfo _methodRef = intermediateTypeClassRef.GetMethod("Start");
                            if (!_methodRef.IsStatic)
                            {
                                object result = _methodRef.Invoke(objRef, new object[] { "deepthi" });
                                Console.WriteLine(result.ToString());
                            }

                        }

                    }
                    break;
                case Options.ADVANCED:
                    Console.WriteLine("Advanced Level");
                    System.Reflection.Assembly advancedLevelLib =
                    System.Reflection.Assembly.LoadFile(@"C:\Users\deepthi.np\source\repos\GameApp\GameApp\bin\Debug\netcoreapp3.1\AdvancedLevelLib.dll");
                    System.Type advancedTypeClassRef = advancedLevelLib.GetType("AdvancedLevelLib.AdvancedLevelType");

                    if (advancedTypeClassRef != null)
                    {
                        if (advancedTypeClassRef.IsClass)
                        {

                            Object objRef = System.Activator.CreateInstance(advancedTypeClassRef);
                            System.Reflection.MethodInfo _methodRef = advancedTypeClassRef.GetMethod("Begin");
                            if (!_methodRef.IsStatic)
                            {

                                object result = _methodRef.Invoke(objRef, new object[] { "deepthi", 20 });
                                Console.WriteLine(result.ToString());
                            }

                        }

                    }
                    break;

            }

        }
    }
}
