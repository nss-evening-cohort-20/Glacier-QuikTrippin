// See https://aka.ms/new-console-template for more information
using Glacier_QuikTrippin;

Console.WriteLine("test1");
DistrictRepository repository= new DistrictRepository();
District test =new District(repository);
District test2=new District(repository);
District test3=new District(repository);
var repo = repository.GetDistricts();
foreach (var item in repo)
{
    Console.WriteLine(item.Id);
}

Title title = new Title();
title.DisplayTitle();

string prompt = "Please use the arrows keys to navigate the menu. Press enter to make a selection.";
string[] options= { "option1", "option2", "option3" };

Menu mainMenu = new Menu(prompt, options);
mainMenu.Run();

while (true)
{

}