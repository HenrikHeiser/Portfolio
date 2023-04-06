using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
using System.Runtime.CompilerServices;

namespace VanSchaeuffelenHatLangeweile
{
    internal class Reginput
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string value = "";
            List<string> compilationList = new List<string>();
            //Dateipfade angeben
            string itschule = "it.schule_Stuttgart.html";
            string table = @"C:\\Users\\HEISERH\\source\\repos\\VanSchaeuffelenHatLangeweile\\VanSchaeuffelenHatLangeweile\\bin\\Debug\\table.html";
            //String für das Umtauschen 
            string replaceS = "$2 $1";
            //Datei 1 einlesen
            string itSchuleText = File.ReadAllText(itschule);
            //Datei 2 einlesen
            string tableText = File.ReadAllText(table);
            //Regex deklarieren
            Regex header = new Regex(@"<h[1-6]+?>([\s\S]*?)</h[1-6]+>");
            Regex links = new Regex("(<a [a-zA-Z0-9=:/\\. ]*>)([a-zA-Z0-9 ]*)(</a>)");
            Regex bilder = new Regex("<img src=“[a-zA-Z0-9\\. ]+”/>|<img src=“[a-zA-Z0-9\\. ]+”></img>");
            Regex tableReg = new Regex("<t[h|d]>(.*?)</t[h|d]>");
            //Match Header
            Match matchHeader = header.Match(itSchuleText);
            while (matchHeader.Success)
            {
                Console.WriteLine(matchHeader.Groups[1].Value);
                matchHeader = matchHeader.NextMatch();
            }
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
