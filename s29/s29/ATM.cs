public abstract class CashDisponser
{
    protected CashDisponser _nextCashDisponser;
    public abstract int BankNoteUnit { get; }

    public void SetNext(CashDisponser nextCashDisponser)
    {
        _nextCashDisponser = nextCashDisponser;
    }


    public void Dispense(int amount)
    {
        int amount2 = amount / BankNoteUnit;
        if (amount2 > 0)
        {
            System.Console.WriteLine($"{BankNoteUnit}Dispenser: Here you are : ${amount2}");
        }
        amount2 = amount % BankNoteUnit;
        if (_nextCashDisponser != null)
        {
            if (amount2 > 0)
                _nextCashDisponser.Dispense(amount2);
        }
        else if (amount2 > 0)
        {
            System.Console.WriteLine($"ERROR : Connot dispense this amount : {amount}");
        }
    }
}

public class CashDisponser100 : CashDisponser
{
    public override int BankNoteUnit => 100;

}

public class CashDisponser50 : CashDisponser
{
    public override int BankNoteUnit => 50;
}

public class CashDisponser20 : CashDisponser
{
    public override int BankNoteUnit => 20;
}

public class CashDisponser10 : CashDisponser
{
    public override int BankNoteUnit => 10;
}

public class CashDisponser5 : CashDisponser
{
    public override int BankNoteUnit => 5;
}