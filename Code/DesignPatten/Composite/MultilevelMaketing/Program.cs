using MultilevelMaketing;

Company alibaba = new Company();

ReferenceMember jack = new ReferenceMember("The weekend bentre", 100);
jack.Add(new NormalMember("Duc Thuan", 60));
jack.Add(new NormalMember("Van Chien", 55));

ReferenceMember kine = new ReferenceMember("Trung Kien SSS", 100);
jack.Add(new NormalMember("Thai Tuan", 60));
jack.Add(new NormalMember("Duc Minh", 59));
jack.Add(new NormalMember("Manh Truong", 75));


ReferenceMember mike = new ReferenceMember("Mkie cocaine", 100);
mike.Add(kine);

alibaba.AddTopMember(jack);
alibaba.AddTopMember(kine);
alibaba.AddTopMember(mike);

alibaba.Show();
System.Console.WriteLine($"Total income: {alibaba.CalculateIncome()}");