using laba_4.Adapters;
using laba_4.Interfaces;
using laba_4.Realizations;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John Doe", new DateTime(1990, 5, 15));

        IAgeInfo ageInfo = new PersonAdapter(person);
        var res = ageInfo.PrintInitialsAndAge();
        Console.WriteLine(res);
    }
}
