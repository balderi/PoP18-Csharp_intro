using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoting
{
    class Class1 : MyInterface
    {
        public delegate string MyDel(int tal, string tekst);

        protected int tal;
        public int tal2;

        /// <summary>
        /// Min nye klasse
        /// </summary>
        /// <param name="tal1">det private tal</param>
        /// <param name="tal2">det offetlige tal</param>
        public Class1(int tal1, int tal2)
        {
            tal = tal1;
            this.tal2 = tal2;
        }

        public string DelMeth(MyDel metode)
        {
            return metode(13, "delegate!");
        }

        public void MyMethod(string data, int count)
        {
            MessageBox.Show(count.ToString(), data);
        }

        public string StringMthd(int tal)
        {
            return "Tallet er " + tal.ToString();
        }
    }
}
