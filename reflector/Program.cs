using System;
using System.Reflection;
using System.Linq;

var asm = Assembly.LoadFrom("c:\\Users\\nemir\\source\\repos\\Tyuiu.IzingerVA.Sprint1\\tyuiu.cources.programming.interfaces.dll");
var type = asm.GetTypes().FirstOrDefault(t => t.Name == "ISprint1Task2V16");
if(type != null) {
    foreach(var m in type.GetMethods()) {
        Console.Write(m.ReturnType.Name + " " + m.Name + "(");
        var pNames = m.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name).ToArray();
        Console.WriteLine(string.Join(", ", pNames) + ")");
    }
}
