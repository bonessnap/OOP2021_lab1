using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Zadanie_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        List<product> mylist = new List<product>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        { // кнопка добавления
            add_form f1 = new add_form(); // форма для ввода данных про продукт
            f1.ShowDialog();
            mylist.Add(f1.prodAdd()); // добавляет возвращаемый функцией в форме продукт
            F_Listbox(); // выводит список в листбокс
        }

        private void button2_Click(object sender, EventArgs e)
        { // кнопка приготовления
            if (textBox1.Text.Length > 0 && Convert.ToInt32(textBox1.Text) < mylist.Count)
                F_Cook(mylist[Convert.ToInt32(textBox1.Text)]);
        }
        private void F_Listbox()
        { // процедура выводит список продуктов в листбокс
            listBox1.Items.Clear();
            for (int i = 0; i < mylist.Count; i++)
                listBox1.Items.Add(F_dataReturn(mylist[i]));
        }
        private string F_dataReturn(product temp)
        { // функция возвращает строку с данными о продукте в зависимости от его типа
            if (temp is vegetables)
            {
                vegetables vegetabletemp = (vegetables)temp;
                return vegetabletemp.name + ", калорийность: " + vegetabletemp.calories + ", вес: " + vegetabletemp.weight;
            }
            else if (temp is fruit)
            {
                fruit fruittemp = (fruit)temp;
                return fruittemp.name + ", обьем: " + fruittemp.capacity + ", витаминов: " + fruittemp.vitamins;
            }
            else
            {
                dessert desserttemp = (dessert)temp;
                return desserttemp.name + ", калории: " + desserttemp.calorites + ", % какао: " + desserttemp.cacaopercent;
            }
        }

        private void F_Cook(product temp)
        { // вывод порций в лейбл
            label2.Text = "";
            if (temp is vegetables)
            {
                vegetables vegetabletemp = (vegetables)temp;
                label2.Text += vegetabletemp.name + ".\nПорций: " + (vegetabletemp.weight / 200) + ".\nВес порций: 200г.";
            }
            else if(temp is fruit)
            {
                fruit fruittemp = (fruit)temp;
                label2.Text += fruittemp.name + ".\nПорций: " + (fruittemp.vitamins / 100) + ".\nВес порций: 100г витаминов.";
            }
            else
            {
                dessert desserttemp = (dessert)temp;
                if (desserttemp.cacaopercent < 60)
                    label2.Text += desserttemp.name + ".\nПорций: " + (desserttemp.calorites / 150) + ".\nВес порций: 150г калорий.";
                else label2.Text += desserttemp.name + ".\nПорций: " + (desserttemp.calorites / 50) + ".\nВес порций: 50г калорий.";
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { // вводим только цифры в текстбокс
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
