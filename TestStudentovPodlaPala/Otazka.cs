using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStudentovPodlaPala
{
    class Otazka
    {
        public string Text;
        private Moznost[] moznosti = new Moznost[3];
        public Moznost[] Moznosti
        {
            get
            {
                return moznosti;
            }
            set
            {
                moznosti = value;
            }
        }

        public Moznost[] Odpovede
        {
            get;
            set;
        }

        public void VypisOtazku()
        {
            Console.WriteLine(Text);
            Console.WriteLine("-------------------------");
            foreach (Moznost m in moznosti)
            {
                Console.WriteLine(m.Text);
            }
        }
    }

    class SingleOtazka: Otazka
    {

    }
    class MultiOtazka: Otazka
    {

    }
}
