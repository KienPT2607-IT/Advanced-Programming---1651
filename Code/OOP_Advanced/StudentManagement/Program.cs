using StudentManagement;

School a = new School();
bool running = true;
while (running)
{
    a.PrintMenu();
    int choice = a.GetChoice();
    a.Process(choice);
    running = (choice != 0);
}