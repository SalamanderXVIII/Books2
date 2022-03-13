using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    public class Themes
    {
        public int n;
        public string[] BookAuthors;
        public string[] Author = { "Christie", "Defoe", "Dickens", "Galsworthy", "Shakespeare" };
        public string[] Theme_str;
        public Theme theme;
        public Random random;
        public Themes()
        {
            n = 20;
            BookAuthors = new string[n];
            Theme_str = new string[n];
            random = new Random();
            int k = 0;
            for (int i = 0; i < Author.Length; i++)
            {
                for (int j = k; j < k+4; j++)
                {
                    BookAuthors[j] = Author[i];
                }
                k += 4;
            }
            int themename;
            for (int i = 0; i < Theme_str.Length; i++)
            {
                themename = random.Next(4);
                Theme theme = (Theme)themename;
                Theme_str[i] = Convert.ToString(theme);
            }
        }
    }
}
