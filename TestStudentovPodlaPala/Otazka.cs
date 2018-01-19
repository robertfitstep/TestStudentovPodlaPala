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
        public int Body;
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

        public virtual int VyhodnotOtazku()
        {
            return 0;
        }
        
    }

    class SingleOtazka: Otazka
    {
        public override int VyhodnotOtazku()
        {
            foreach(Moznost odpoved in Odpovede)
            {
                if (odpoved.Spravnost) return 1;
            }
            return 0;
        }
    }
    class MultiOtazka: Otazka
    {
        public override int VyhodnotOtazku()
        {
            int body=0;
            foreach (Moznost odpoved in Odpovede)
            {
                if (odpoved.Spravnost == true) body++;
                else body--;
            }
            return body;
        }
    }
}
