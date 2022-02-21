// See https://aka.ms/new-console-template for more information

using Internship_Linq;

//DelegateExample();
//ExtenssionsExample();
LinqExamples();




void DelegateExample()
{
    var users = new List<User>
    {
        new User{FirstName = "Alan", Age = 22},
        new User{FirstName = "Marta", Age = 15},
        new User{FirstName ="Bob", Age = 11}
    };

    var userArray = users.ToArray();

   // BubbleSorter.Sort(userArray, new BubbleSorter.IsAGreaterThanBDeleGate(CompareUsers));
    BubbleSorter.Sort(userArray, CompareUsers);
    BubbleSorter.Sort(userArray, delegate (User a, User b) { return a.Age > b.Age; });
    BubbleSorter.Sort(userArray, (a, b) => a.Age > b.Age);

    foreach (var user in userArray)
    {
        Console.WriteLine($"{user.FirstName} {user.Age}");
    }
}

bool CompareUsers(object a, object b)
{
    var user1 = (User)a;
    var user2 = (User)b;
    return user1.Age > user2.Age;
}




void ExtenssionsExample()
{
    var list = new List<string> { "a", "b" };

    "xasd".AddTo(list);
    Extenssions.AddTo("ddd", list);

    string abs = null;

    abs.AddTo(list);

    return;
}





void LinqExamples()
{
    var users = new List<User>
    {
        new User{FirstName = "Alan", Age = 22},
        new User{FirstName = "Marta", Age = 15},
        new User{FirstName ="Bob", Age = 11}
    };

    var s = users
        .OrderBy(x => x.Age).Where(AgeFilter)
        .Select(x=> new { x.FirstName });

    users.Add(new User { FirstName = "John", Age= 21 });

    var orderedUsers = s.ToList();

    foreach (var item in orderedUsers)
    {
        Console.WriteLine(item.FirstName);
    }
}

bool AgeFilter (User user)
{
    return user.Age > 14;
}
