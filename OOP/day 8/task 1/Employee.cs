using System.Globalization;

namespace task_1;

public struct Employee
{
    private int id;

    private int salary;
    HireDate hireDate;

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public int Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    private Gender gender;
    public Gender EGender
    {
        get { return this.gender; }
        set { this.gender = value; }
    }

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    private SecurityLevel sLevel;

    public SecurityLevel SLevel
    {
        get { return this.sLevel; }
        set { this.sLevel = value; }
    }

    public HireDate Hdate
    {
        get { return this.hireDate; }
        set { this.hireDate = value; }
    }

    public override string ToString()
    {
        string newString = this.salary.ToString("C", CultureInfo.CurrentCulture);
        return $"Salary:{newString}\nID:{this.id}\nGender:{this.gender}\nSLevel:{this.sLevel}\nDate:{this.hireDate}";
    }

    public Employee(int _id, int _salary, Gender _gender, SecurityLevel _slevel)
    {
        this.id = _id;
        this.salary = _salary;
        this.gender = _gender;
        this.sLevel = _slevel;
        // this.hireDate = new HireDate();
    }

    public Employee(
        int _id,
        int _salary,
        Gender _gender,
        SecurityLevel _slevel,
        int d,
        int m,
        int y
    )
    {
        this.id = _id;
        this.salary = _salary;
        this.gender = _gender;
        this.sLevel = _slevel;
        this.hireDate = new HireDate(d, m, y);
    }
}
