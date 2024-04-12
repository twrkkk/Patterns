using laba_4.Interfaces;

namespace laba_4.Realizations;

public class Person : IPersonInfo
{
    private readonly string _fullName;
    private readonly DateTime _dateOfBirth;

    public Person(string fullName, DateTime dateOfBirth)
    {
        _fullName = fullName;
        _dateOfBirth = dateOfBirth;
    }

    public string PrintFullNameAndDOB()
    {
        return $"Full Name: {_fullName}, Date of Birth: {_dateOfBirth.ToShortDateString()}";
    }

    public DateTime GetDateOfBirth()
    {
        return _dateOfBirth;
    }

    public string GetFIO()
    {
        return _fullName;
    }
}
