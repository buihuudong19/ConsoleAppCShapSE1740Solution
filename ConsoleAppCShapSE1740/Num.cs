

namespace ConsoleAppCShapSE1740;

public class Num
{
    //fields/data
    private int _num01;
    public int Num01 { get => _num01; set => _num01 = value; }
    public int Num02 { get; set; }

    public Num()
    {
        Num01 = 0;
        Num02 = 0;
    }

    public Num(int num01, int num02)
    {
        Num01 = num01;
        Num02 = num02;
    }
    public int Add() => Num01+ Num02;
    public int Sub() => Num01- Num02;
    public int Mul() => Num01* Num02;
    public int Div() => Num01/ Num02;
}
