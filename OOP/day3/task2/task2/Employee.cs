namespace task2
{
    public class Employee
    {
        private string ssn;
        private int salary;

        public void setSNN(string _ssn)
        {
            ssn = _ssn;
        }

        public void setSalary(int _salary)
        {
            salary = _salary;
        }

        public string getSNN()
        {
            return ssn;
        }

        public int getSalary()
        {
            return salary;
        }

        public string toString()
        {
            return $"ssn:{ssn}: salary:{salary}";
        }
    }
}
