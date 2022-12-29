using DemoStrategy;

Class GCH1001 = new Class(new SortByName());
GCH1001.AddStudent(new Student("Ngoc Anh", 20, 8.5));
GCH1001.AddStudent(new Student("Trung Kien", 20, 7.5));
GCH1001.AddStudent(new Student("Thu Thao", 8, 8));
GCH1001.AddStudent(new Student("Pham Hue", 27, 7));
GCH1001.AddStudent(new Student("Minh Duc", 26, 5));

GCH1001.Show();
System.Console.WriteLine("_______________ Change sorter");

GCH1001.ChangeSorter(new SortByAge());
GCH1001.Show();
System.Console.WriteLine("_______________ Change sorter");

GCH1001.ChangeSorter(new SortByGPA());
GCH1001.Show();
System.Console.WriteLine("_______________ Change sorter");