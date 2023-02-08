namespace Glacier_QuikTrippin;

public class Title
{
    private string _title = @"
 ________  ___  ___  ___  ________  ___  __    _________  ________  ___  ________   
|\   __  \|\  \|\  \|\  \|\   ____\|\  \|\  \ |\___   ___\\   __  \|\  \|\   __  \  
\ \  \|\  \ \  \\\  \ \  \ \  \___|\ \  \/  /|\|___ \  \_\ \  \|\  \ \  \ \  \|\  \ 
 \ \  \\\  \ \  \\\  \ \  \ \  \    \ \   ___  \   \ \  \ \ \   _  _\ \  \ \   ____\
  \ \  \\\  \ \  \\\  \ \  \ \  \____\ \  \\ \  \   \ \  \ \ \  \\  \\ \  \ \  \___|
   \ \_____  \ \_______\ \__\ \_______\ \__\\ \__\   \ \__\ \ \__\\ _\\ \__\ \__\   
    \|___| \__\|_______|\|__|\|_______|\|__| \|__|    \|__|  \|__|\|__|\|__|\|__|   
          \|__|                                                                     
";
    private string _subTitle = "Management Systems";
    private string _authors = "Created By: Ganesh Babu, Jeremy White, & Robert Stroud";

    public void DisplayTitle()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_subTitle);
        Console.WriteLine(_authors);
    }

}


