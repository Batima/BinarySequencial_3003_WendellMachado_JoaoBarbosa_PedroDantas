using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<int> arrayai = new List<int>();
        int times;
        public Form1()
        {
            InitializeComponent();
        }

        void CreateArray(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(textarray.Text); i++)
            {
                arrayai.Add(i);
                Console.WriteLine(i);
            }
           
        }

        void PrintBinary(object sender, EventArgs e)
        {
            Console.WriteLine("número procurado " + BinarySearch(arrayai, Convert.ToInt32(textbinary.Text)) + " " + "vezes procurado " + times);
        }

        int BinarySearch(List<int> array, int target)
        {
            int left, middle, right;
            left = -1;
            right = array.Count;
            times = 0;
            while (left < right - 1)
            {
                times++;
                middle = (left + right) / 2;
                if (array[middle] == target)
                {
                    right = middle;
                    break;
                }
                else if (array[middle] < target)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }
            return right;
        }

        private void PrintSequencial(object sender, EventArgs e)
        {
            Console.WriteLine("número procurado " + BinarySearch(arrayai, Convert.ToInt32(textsequential.Text)) + " vezes procurado " + arrayai.Count);
        }

        bool SequentialSearch(List<int> array, int target)
        {
            times = 0;
            int i;
            for (i = 0; i < array.Count; i++)
            {
                // teste para conjuntos ordenados
                if (target < array[i])
                {
                    break;
                }
                if (target == array[i])
                {
                    Console.WriteLine((++i).ToString() + " elemento(s) testado(s).");
                    return true;
                }
            }

            if (i == array.Count)
            {
                Console.WriteLine(i.ToString() + " elemento(s) testado(s).");
            }
            else
            {
                Console.WriteLine((++i).ToString() + " elemento(s) testado(s).");
            }
            return false;
        }
    }
}
