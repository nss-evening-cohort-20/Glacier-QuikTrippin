namespace Glacier_QuikTrippin;

public static class Title
{
    private static string _title = @"
 -------------------------------------------------------------------------------------------
|   ________  ___  ___  ___  ________  ___  __    _________  ________  ___  ________        |
|  |\   __  \|\  \|\  \|\  \|\   ____\|\  \|\  \ |\___   ___\\   __  \|\  \|\   __  \       |
|  \ \  \|\  \ \  \\\  \ \  \ \  \___|\ \  \/  /|\|___ \  \_\ \  \|\  \ \  \ \  \|\  \      |    
|   \ \  \\\  \ \  \\\  \ \  \ \  \    \ \   ___  \   \ \  \ \ \   _  _\ \  \ \   ____\     |
|    \ \  \\\  \ \  \\\  \ \  \ \  \____\ \  \\ \  \   \ \  \ \ \  \\  \\ \  \ \  \___|     |
|     \ \_____  \ \_______\ \__\ \_______\ \__\\ \__\   \ \__\ \ \__\\ _\\ \__\ \__\        |
|      \|___| \__\|_______|\|__|\|_______|\|__| \|__|    \|__|  \|__|\|__|\|__|\|__|        |
|            \|__|                                                                          |
|                                      MANAGEMENT SYSTEMS                                   |
|                                                                                           |
|                     CREATED BY: GANESH BABU, JEREMY WHITE, & ROBERT STROUD                |
 -------------------------------------------------------------------------------------------";
    private static string _subTitle = "Management Systems";
    private static string _authors = "Created By: Ganesh Babu, Jeremy White, & Robert Stroud";

    public static void DisplayTitle()
    {
        Console.WriteLine(_title);     
        Console.WriteLine("");
    }

}


