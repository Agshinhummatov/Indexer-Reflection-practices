

#region Indexer,Reflection


using Indexer_Reflection_practices.Controller;
using Indexer_Reflection_practices.Models;
using System.Reflection;

//Book book1 = new Book() { Id = 1, Name = "Xosrov" };
//Book book2 = new Book() { Id = 2, Name = "7 gozel" };

//Librarey librarey = new();

//librarey[0] = book1;


////Console.WriteLine(librarey[0].Name);
////Console.WriteLine(librarey[1].Name);


//Assembly assembly = Assembly.GetEntryAssembly();

//foreach (var item in assembly.GetTypes())
//{
//    foreach (var item1 in item.GetMembers())
//    {
//        Console.WriteLine(item);
//    }

//}
#endregion



AccountController accountController = new();

accountController.Resgister();