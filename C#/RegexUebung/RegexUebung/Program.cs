using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace VanSchaeuffelenHatLangeweile
{
    internal class Program
    {
        static void CooleMethode()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string value = "";
            List<string> compilationList = new List<string>();
            string table = @"C:\\Users\\HEISERH\\source\\repos\\VanSchaeuffelenHatLangeweile\\VanSchaeuffelenHatLangeweile\\bin\\Debug\\table.html";
            //String für das Umtauschen 
            string replaceS = "$2 $1";
            //Datei einlesen
            string tableText = File.ReadAllText(table);
            //Regex deklarieren
            Regex tableReg = new Regex("<t[h|d]>(.*?)</t[h|d]>");
            //Match Table
            Match matchTable = tableReg.Match(tableText);
            //jeweiliges Match einer Liste hinzufügen
            while (matchTable.Success)
            {
                compilationList.Add(matchTable.Groups[1].Value);
                matchTable = matchTable.NextMatch();
            }
            //für jedes Item der Liste wird es ausgegeben & einem string hinzugefügt
            for (int i = 0; i < compilationList.Count; i++)
            {
                Console.WriteLine(compilationList[i]);
                value = compilationList[i] + value;
            }
            //Replaced 
            Console.WriteLine(value, replaceS);

            Console.ReadKey();
        }
    }
}
