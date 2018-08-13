using System;
//test class for github
public class TestClass
{
    public TestClass() { }

    /// <summary>
    /// adds a with b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// subtract b from a
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// mutliply groups of a with value of b
    /// </summary>
    /// <param name="a">groups of</param>
    /// <param name="b">value of</param>
    /// <returns></returns>
    private int PrimitiveMultiplication(int a, int b)
    {
        int result;
        //add b to result a times
        for (int i = 0; i < a; ++i)
        {
            result + b;
        }
        return result;
    }

    //hack test
    static void Main()
    {
        Console.WriteLine( PrimitiveMultiplication(3, 4));
        Console.ReadKey();
    }
}
