﻿namespace Glacier_QuikTrippin;

public class Menu

{
    private int _selectedIndex;
    private string[] _options;
    private string _prompt;

    public Menu(string prompt, string[] options) 
    {
        _prompt = prompt;
        _options = options;
        _selectedIndex = 0;
    }
    private void DisplayOptions()
    {
        Console.WriteLine(_prompt);
        Console.WriteLine();
        for(int i =0; i< _options.Length; i++)
        {
            string currentOption = _options[i];
            string prefix;

            if(i == _selectedIndex)
            {
                prefix = "> ";
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor= ConsoleColor.White;
            }
            else 
            {
                prefix = "  ";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor= ConsoleColor.Black;
            }

            Console.WriteLine($"{prefix}{currentOption}");
        }
        Console.ResetColor();
    }

    public int Run()
    {
        ConsoleKey keyPressed;
        do
        {
            Console.Clear();
            Title.DisplayTitle();
            DisplayOptions();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed= keyInfo.Key;

            if( keyPressed == ConsoleKey.UpArrow)
            {
                _selectedIndex--;
                if(_selectedIndex == -1)
                {
                    _selectedIndex = _options.Length - 1;
                }
            }
            else if(keyPressed == ConsoleKey.DownArrow)
                {
                _selectedIndex++;
                if(_selectedIndex > _options.Length-1)
                {
                    _selectedIndex = 0;
                }
            }
        }
        while (keyPressed != ConsoleKey.Enter);
        return _selectedIndex;
    }
}
