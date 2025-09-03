public interface Animal{

    public void sound();

}

public class CAt : Animal
{
    public string a_sound = "Mewo";
    public void sound()
    {
        System.Console.WriteLine($"i say {a_sound} {a_sound}");
    }
}