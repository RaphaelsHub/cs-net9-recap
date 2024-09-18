using Csharp_Lessons.Classes;

namespace Csharp_Lessons;

class Program
{
    static void Main()
    {
        object obj = new VariableLesson();
        (obj as VariableLesson)?.VariablePropreties();
        
        VariableLesson variableLesson =(obj as VariableLesson)?? new VariableLesson();
        
        variableLesson.MathStaticFunctions();
        variableLesson.RandomNumsTest();
        variableLesson.BoxingUnboxingTest();
    }
}