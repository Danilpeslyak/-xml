using System;
using System.Data;
using System.IO;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;


class Program
{
    static void Main(string[] args)
    {
        string[] telephone = File.ReadAllLines("input.txt");

        string result =
            $"<?xml version ='1.0' encoding='UTF-16'?>\n" +
            $"<?xml-stylesheet type='text/css' href='Rules.css'?>\n" +
            "\n<info>";

        foreach (string s in telephone)
        {
            string[] data = s.Split(',');

            result += $"\n<telephone>\n" +
                $"<name>{data[0]}</name>\n" +
                $"<avtor>{data[1]}</avtor>\n" +
                $"<color>{data[2]}</color>\n" +
                $"<type>{data[3]}</type>\n" +
                $"<size>{data[4]}</size>\n" +
                $"<year>{data[5]}</year>\n" +
                $"<batery>{data[6]}</batery>\n" +
                $"<time>{data[7]}</time>\n" +
                $"<chehol>{data[8]}</chehol>\n";
            result += $"</telephone>\n";
        }
        result += "</info>";
        File.WriteAllText(@"C:\Users\user\Desktop\output.xml", result);
    }
}