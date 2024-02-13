/*

WARNING! This program contains HOLY TEXT FROM THE ONE AND ONLY GOD. DO NOT EDIT THIS TEXT. 

			    Revelation 22:18	
	"For I testify unto every man that heareth the words of the prophecy of this book, If any man shall add unto these things, God shall add unto him the plagues that are written in this book: ¹⁹And if any man shall take away from the words of the book of this prophecy, God shall take away his part out of the book of life, and out of the holy city, and from the things which are written in this book. "
	
This program uses the King James Version of the bible.

*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string file = "Bible.txt"; // Path to your text file
        string VerseToFind = "For he so loved the world"; // Word you want to find

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(file);

            // Loop through each line and search for the word
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(VerseToFind))
                {
                    Console.WriteLine($"Bile verse '{VerseToFind}' found on line {i + 1}. The verse is {lines[i]}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while checking the bible: {e.Message}");
        }
    }
}
