using System;
using System.Reflection;

class Program {
    static void Main() {
        var asm = Assembly.LoadFrom("c:\\Users\\nemir\\source\\repos\\Tyuiu.IzingerVA.Sprint1\\tyuiu.cources.programming.interfaces.dll");
        var type = asm.GetType("tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task3V16");
        foreach(var m in type.GetMethods()) {
            Console.WriteLine(m.ReturnType.Name + " " + m.Name + "(");
            foreach(var p in m.GetParameters()) {
                Console.WriteLine(p.ParameterType.Name + " " + p.Name);
            }
            Console.WriteLine(")");
        }
    }
}
