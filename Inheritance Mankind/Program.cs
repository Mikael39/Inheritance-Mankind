namespace Inheritance_Mankind
{
    public class Program
    {
        static void Main(string[] args)
        {
            try

            {
                string[] values = Console.ReadLine().Split(' ');
                string firstName = values[0];
                string lastName = values[1];
                int facultyNumber = int.Parse(values[2]);

                Student student = new Student(facultyNumber, firstName, lastName);

                string[] values2 = Console.ReadLine().Split(' ');
                string firstName2 = values2[0];
                string lastName2 = values2[1];
                int salary = int.Parse(values2[2]);
                int workingHours = int.Parse(values2[3]);
                double hourlyWage = salary / (workingHours * 5);

                Worker worker = new Worker(salary, workingHours, firstName2, lastName2, hourlyWage);

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }

            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}