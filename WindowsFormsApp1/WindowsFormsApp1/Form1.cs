using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string arr;
        public string arr2;
        public static int n;
        public static int n1;
        public int[] array = new int[n];
        public int[] array2 = new int[n1];
        //public string vyvod;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void peresech_Click(object sender, EventArgs e)
        {
            int[] array3 = new int[array.Length + array2.Length];
            array.CopyTo(array3, 0);
            int count = array.Length;

            for (int i = 0; i < array2.Length; i++)
            {
                if (Array.Exists(array3, s => s == array2[i]) == false)
                    array3[count++] = array2[i];
            }

            Array.Resize(ref array3, count);

            Console.WriteLine("Результаты вычислений ");
            for (int i = 0; i < count; i++)
            {
                textBox5.Text += array3[i].ToString();
                textBox5.Text += " ";
                //Console.WriteLine(array3[i]);
            }
        }

        private void objed_Click(object sender, EventArgs e)
        {
            int[] array3 = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    if (array[i] == array2[j])
                    {
                        array3[k] = array2[j];
                        k++;
                    }
                }

            }
            int[] mas3 = new int[k];
            for (int i = 0; i < k; i++)
            {
                textBox5.Text += array3[i].ToString();
                textBox5.Text += " ";
                //Console.WriteLine(array3[i]);
            }
        }

        public void button3_Click(object sender, EventArgs e)
        { 
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j]) { count++; }
                }
            }
            if (count == 0)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    textBox5.Text += array[i].ToString();
                    textBox5.Text += " ";
                    //Console.WriteLine(array[i]);
                }
            }
            else
            {
                int[] arraypod = new int[array.Length - count];
                //короч надо ща как то написать кусок кода, который будет копировать все элементы первого массива, не совпадающие со вторым, в третий
                int tmp2 = 0;
                // сколько элементов из первого массива?
                for (int i = 0; i < array.Length; i++)
                {
                    bool inBoth = false;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array[i] == array2[j])
                        {
                            inBoth = true;
                            break;
                        }
                    }
                    if (!inBoth)
                        tmp2++;
                }
                int size5 = tmp2;
                int[] array3 = new int[size5];
                tmp2 = 0;

                // второй этап. Те же самые циклы, но уже не считаем, азаписываем уникальные элементы в третий массив

                // помещаем в третий массив элементы из первого массива
                for (int i = 0; i < array.Length; i++)
                {
                    bool inBoth = false;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array[i] == array2[j])
                        {
                            inBoth = true;
                            break;
                        }
                    }
                    if (!inBoth)
                        array3[tmp2++] = array[i];
                }
                for (int i = 0; i < tmp2; i++)
                {
                    textBox5.Text += array3[i].ToString();
                    textBox5.Text += " ";
                    //Console.WriteLine(array3[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n1; i++)
            {
                bool f_A = false, f_B = false;
                for (int j = 0; j < n; j++) if (array[j] == array2[i]) f_A = true;
                if (f_A == false)
                {
                    textBox5.Text = array2[i].ToString();
                    textBox5.Text += " ";

                    //Console.WriteLine(array2[i] + " ");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int tmp = 0;
            // сколько элементов из первого массива?
            for (int i = 0; i < array.Length; i++)
            {
                bool inBoth = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        inBoth = true;
                        break;
                    }
                }
                if (!inBoth)
                    tmp++;
            }

            // сколько элеметов из второго массива?
            for (int i = 0; i < array2.Length; i++)
            {
                bool inBoth = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array2[i] == array[j])
                    {
                        inBoth = true;
                        break;
                    }
                }
                if (!inBoth)
                    tmp++;
            }

            int size3 = tmp;
            int[] arr3 = new int[size3];
            tmp = 0;

            // второй этап. Те же самые циклы, но уже не считаем, а записываем уникальные элементы в третий массив

            for (int i = 0; i < array.Length; i++)
            {
                bool inBoth = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        inBoth = true;
                        break;
                    }
                }
                if (!inBoth)
                    arr3[tmp++] = array[i];
            }

            // помещаем в третий массив элеметы из второго массива
            for (int i = 0; i < array2.Length; i++)
            {
                bool inBoth = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array2[i] == array[j])
                    {
                        inBoth = true;
                        break;
                    }
                }
                if (!inBoth)
                    arr3[tmp++] = array2[i];
            }

            // выводим
            Array.Sort(arr3);
            for (int i = 0; i < size3; i++)
                textBox5.Text += arr3[i].ToString();
            textBox5.Text += " ";


        }
        public int convert_line(ref int[] array, string arr)
        {
            int n = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if(arr[i]!= ' ')
                {
                    array[n] = Convert.ToInt32(arr[i]) - 48;
                    n++;
                }
            }
            return n - 1;

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            n1 = int.Parse(textBox2.Text);
        }

         void textBox3_TextChanged(object sender, EventArgs e)
        {            

            for (int i = 0; i < n; i++)
            {
                arr2 = textBox3.Text;
                array[i] = convert_line(ref array, arr2);
                //array[i] = Int32.Parse(textBox3.Text);
                //array[i] = textBox3.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n.Trim())).ToArray();

                //array[i] = int.Parse(textBox3.Text);

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            arr = textBox4.Text;

            
            for (int k = 0; k < n1; k++)
            {
                array2[k] = convert_line(ref array, arr);
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
