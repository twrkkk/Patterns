using laba_4.Interfaces;

namespace laba_4.Adapters;

public class PersonAdapter : IAgeInfo
{
    private IPersonInfo personInfo;

    public PersonAdapter(IPersonInfo personInfo)
    {
        this.personInfo = personInfo;
    }

    public string PrintInitialsAndAge()
    {
        string[] names = personInfo.GetFIO().Split(' ');
        string initials = "";
        foreach (string name in names)
        {
            initials += name[0];
        }

        DateTime dob = personInfo.GetDateOfBirth();
        int age = DateTime.Now.Year - dob.Year;

        return $"Initials: {initials}, Age: {age}";
    }
}
