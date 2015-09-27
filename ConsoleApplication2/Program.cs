using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string hp;
            hp = Clipboard.GetText();
            var slovechki = hp.Split(' ');
            List<string> l = new List<string>();
            foreach (var slovco in slovechki)
            {
                var al = slovco.Replace(".", " ").Replace(",", "").Replace(":", "").Replace(";", "").Replace("!", "").Replace("?", "");
                l.Add(al);
            }
            l.Sort(StringComparer.CurrentCultureIgnoreCase);
            foreach (var item in l)
            {
                Console.WriteLine(item);
                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
