using HRManagement;
Candidate jh = new Candidate("Kien", 20, 3.8);
System.Console.WriteLine(jh);


List<Candidate> candidates = new List<Candidate>();
candidates.Add(new Candidate("Ngoc Anh", 20, 9));
candidates.Add(new Candidate("Trung Kien", 21, 8));
candidates.Add(new Candidate("Van Tung", 23, 10));
candidates.Add(new Candidate("Van Duc", 30, 5));
candidates.Add(new Candidate("Cong Tien", 35, 3));
candidates.Add(new Candidate("Moon", 17, 6));

HRDepartment hr;

System.Console.Write("Choose department (1)-IT (2)-Sales: ");
string answer = Console.ReadLine();
if (answer == "1")
    hr = new ITHRDepartment();
else
    hr = new SaleHRDeparment();

List<Employee> employees = hr.Recruit(candidates);

System.Console.WriteLine("Congratulations! You have hired the following employees:");
foreach (Employee e in employees)
{
    System.Console.WriteLine(e);
}