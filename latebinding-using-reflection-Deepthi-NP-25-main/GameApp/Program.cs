using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameApp
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
            int repeatableCount = 3;
            do
            {

                string message = string.Format("Enter Your Choice {0}->Basic , {1}->Intermediate ,{2}->Advanced", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);// 1->Basic,2->Intermediate,3->Advanced

                string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
                Console.WriteLine(displayMessage);
                try
                {
                    Options choiceValue = (Options)Int32.Parse(Console.ReadLine());
                    if (choiceValue < (Options)1 || choiceValue > (Options)3)
                    {
                        Console.WriteLine("Invalid Option ");
                    }
                    else
                    {
                        switch (choiceValue)
                        {
                            case Options.BASIC:
                                Console.WriteLine("Basic Level");
                                //Use Reflection  
                                //Assembly Load
                                System.Reflection.Assembly basicLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\deepthi.np\Downloads\latebinding-using-reflection-Deepthi-NP-25-main (1)\latebinding-using-reflection-Deepthi-NP-25-main\GameApp\bin\Debug\LevelLibs\BasicLevellib.dll");
                                System.Type basicLevelTypeClassRef = ConditionLib.ConditionType.FindClass(basicLevelLib, "BasicLevelLib.BasicLevelType");
                                Object obj1Ref = System.Activator.CreateInstance(basicLevelTypeClassRef); //LateBinding
                                System.Reflection.MethodInfo methodInfo = basicLevelTypeClassRef.GetMethod("Play");
                                Object result1 = ConditionLib.ConditionType.InvokeMethod(obj1Ref, methodInfo, new object[] { });
                                Console.WriteLine(result1.ToString());
                                break;
                            case Options.INTERMEDIATE:
                                Console.WriteLine("Intermediate Level");
                                System.Reflection.Assembly intermediateLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\deepthi.np\Downloads\latebinding-using-reflection-Deepthi-NP-25-main (1)\latebinding-using-reflection-Deepthi-NP-25-main\GameApp\bin\Debug\LevelLibs\IntermediateLevellib.dll");
                                System.Type intermediateLevelTypeClassRef = ConditionLib.ConditionType.FindClass(intermediateLevelLib, "IntermediateLevelLib.IntermediateLevelType");
                                Object obj2Ref = System.Activator.CreateInstance(intermediateLevelTypeClassRef); //LateBinding
                                System.Reflection.MethodInfo methodInfo2 = intermediateLevelTypeClassRef.GetMethod("Start");
                                Object result2 = ConditionLib.ConditionType.InvokeMethod(obj2Ref, methodInfo2, new object[] { "deepthi123" });
                                Console.WriteLine(result2.ToString());
                                break;
                            case Options.ADVANCED:
                                Console.WriteLine("Advanced Level");
                                System.Reflection.Assembly advancedLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\deepthi.np\Downloads\latebinding-using-reflection-Deepthi-NP-25-main (1)\latebinding-using-reflection-Deepthi-NP-25-main\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll");
                                System.Type advancedLevelTypeClassRef = ConditionLib.ConditionType.FindClass(advancedLevelLib, "AdvancedLevelLib.AdvancedLevelType");
                                Object obj3Ref = System.Activator.CreateInstance(advancedLevelTypeClassRef); //LateBinding
                                System.Reflection.MethodInfo methodInfo3 = advancedLevelTypeClassRef.GetMethod("Begin");
                                Object result3 = ConditionLib.ConditionType.InvokeMethod(obj3Ref, methodInfo3, new object[] { "deepthi", 50 });
                                Console.WriteLine(result3.ToString());
                                break;
                        }
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("option must be a number" + ex);
                }
                --repeatableCount;
            } while (repeatableCount > 0);
        }
    }
}
