using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Configuration;
using System.IO;

namespace Sqli
{
    public class Security
    { 
        public static Tuple<bool, string> Check(string rowText , string context , string confname)
        {
            bool msg = true;
            string entry = rowText;
            XmlDocument doc = new XmlDocument();
            doc.Load(context+ confname);
            string method1 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method1']").Attributes["value"].Value;
            string method2 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method2']").Attributes["value"].Value;
            string method3 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method3']").Attributes["value"].Value;

            if (method1=="true")
            {
                entry=CleanningText(rowText, 1);
            }
            if (method2 == "true")
            {
                entry = CleanningText(rowText, 2);
            }
            if (method3 == "true")
            {
                msg = CheckText(rowText);
            }

            return Tuple.Create(msg, entry);
        }

        public static string CleanningText(string Entry,int option)
        {
            char[] Entrychars = Entry.ToCharArray();
            char[] Tokens = { '-', '\'', ';', '<', '>', '=', '!', '?' };
            string AfterCleanning = "";
            string temp;
            string[] TokensReplacment = { "[subtraction]", "[SingleQuets]", "[semicolon]", "[Greater]", "[Lesser]", "[Equal]", "[Exclamation]", "[question]" };
            

            if (option==1)
            {
                for (int i = 0; i < Entrychars.Length; i++)
                {
                    temp = Entrychars[i].ToString();
                    for (int j = 0; j < Tokens.Length; j++)
                    {
                        if (Entrychars[i] == Tokens[j])
                        {
                            temp = " ";
                        }
                    }
                    AfterCleanning += temp;
                }
            }
            
            if (option == 2)
            {
                for (int i = 0; i < Entrychars.Length; i++)
                {
                    temp = Entrychars[i].ToString();
                    for (int j = 0; j < Tokens.Length; j++)
                    {
                        if (Entrychars[i] == Tokens[j])
                        {
                            temp = TokensReplacment[j];
                        }
                    }
                    AfterCleanning += temp;
                }
            }
            
            return AfterCleanning;
        }

        public static bool CheckText(string Entry)
        {
            char[] Entrychars = Entry.ToCharArray();
            char[] Tokens = { '-', '\'', ';', '<', '>', '=', '!', '?' };
            for (int i = 0; i < Entrychars.Length; i++)
            {
                for (int j = 0; j < Tokens.Length; j++)
                {
                    if (Entrychars[i] == Tokens[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
   
}