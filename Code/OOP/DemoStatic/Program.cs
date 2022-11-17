using DemoStatic;
// See https://aka.ms/new-console-template for more information
Student st1 = new Student("Bo Kien", 20);
Student st2 = new Student("Hua Trung Kien", 20);
st1.ShowInfo();
Student.School = "XanhWich";
st2.ShowInfo();