namespace s29;

class Program
{
    static void Main(string[] args)
    {
        var cd100 = new CashDisponser100();
        var cd50 = new CashDisponser50();
        var cd20 = new CashDisponser20();
        var cd10 = new CashDisponser10();
        var cd5 = new CashDisponser5();

        cd100.SetNext(cd50);
        cd50.SetNext(cd20);
        cd20.SetNext(cd10);
        cd10.SetNext(cd5);

        cd100.Dispense(5235);
        System.Console.WriteLine();

    }
}
