using System;
using System.Reflection;

try {
    var m = typeof(Dummy).GetMethod("Calculate");
    Console.WriteLine(m.Name);
} catch (Exception ex) {
    Console.WriteLine(ex.GetType().Name);
}

class Dummy {
    public int Calculate(double value) => 0;
    public double Calculate(int value) => 0.0;
}
