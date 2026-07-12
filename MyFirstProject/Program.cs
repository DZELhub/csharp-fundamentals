using MyFirstProject.Lessons;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var lessons = new Dictionary<int, Action>
            {
                {1, Lesson01_Basics.Run},
                {2, Lesson02_Variables.Run},
                {3, Lesson03_Variables.Run},
                {4, Lesson04_Variables.Run},
                {5, Lesson05_Variables.Run},
                {6, Lesson06_DataTypes.Run},
                {7, Lesson07_DataTypes.Run},
                {8, Lesson08_09_DataTypesConvertion.Run},
                {10, Lesson10_NullableTypes.Run},
                {11, Lesson11_String.Run},
                {12, Lesson12_StringMethods.Run},
                {13, Lesson13_StringPractise.Run},
                {14, Lesson14_DateTime.Run},
                {15, Lesson15_Array.Run},
                {16, Lesson16_Array.Run},
                {17, Lesson17_ArrayMethods.Run},
                {18, Lesson18_ArraySlicing.Run},
                {19, Lesson19_ArrayPractise.Run},
                {20, Lesson20_MultidimensionalArray.Run},
                {21, Lesson21_ReferenceType.Run},
                {22, Lesson22_Operators.Run},
                {23, Lesson23_ArithmeticOperators.Run},
                {24, Lesson24_AssignmentOperators.Run},
                {25, Lesson25_ComparisonOperators.Run},
                {26, Lesson26_ComparisonOperators.Run},
                {27, Lesson27_LogicalOperators.Run},
                {28, Lesson28_LogicalOperatorsExercise.Run},
                {29, Lesson29_RandomOperators.Run},
                {30, Lesson30_IfElse.Run},
                {31, Lesson31_IfElse.Run},
                {32, Lesson32_IfElse.Run},
                {33, Lesson33_SwitchCase.Run},
                {34, Lesson34_Ternary.Run},
                {35, Lesson35_ForLoop.Run},
                {36, Lesson36_ForLoopExercise.Run},
                {37, Lesson37_WhileLoop.Run},
                {38, Lesson38_BreakContinue.Run},
                {39, Lesson39_WhileLoopExercise.Run},
                {40, Lesson40_DoWhile.Run},
                {41, Lesson41_Foreach.Run},
                {42, Lesson42_FileReading.Run},
                {43, Lesson43_AddRemoveInfo.Run},
                {44, Lesson44_Docs.Run},
                {45, Lesson45_FileManagement.Run},
                {46, Lesson46_ProgramClass.Run},
                {47, Lesson47_ClassExercise.Run},
                {48, Lesson48_Methods.Run},
                {49, Lesson49_MethodsExercise.Run},
                {50, Lesson50_Constructors.Run},
                {51, Lesson51_AccessModifiers.Run},
                {52, Lesson52_StaticMethods.Run},
                {53, Lesson53_Collections.Run},
                {54, Lesson54_ArrayList.Run}
            };

            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== DZEL C# LESSON MENU =====");
                Console.WriteLine("Çıkış için 0 yaz");

                foreach (var lesson in lessons.Keys.OrderBy(x => x))
                {
                    Console.WriteLine($"Lesson {lesson}");
                }

                Console.Write("\nSeçim: ");
                string input = Console.ReadLine() ?? "Hatalı Giriş";

                if (input == "0") break;

                if (int.TryParse(input, out int choice) && lessons.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine($"--- Lesson {choice} ---\n");

                    lessons[choice].Invoke();

                    Console.WriteLine("\nDevam etmek için bir tuşa bas...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}