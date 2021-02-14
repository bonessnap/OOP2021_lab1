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
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            StartPosition = FormStartPosition.CenterScreen;
        }
        product prod = new product();
        // наш продукт

        public product prodAdd()
        { // функция, которая возвращает продукт
            return prod;
        }
        private void button1_Click(object sender, EventArgs e)
        { // добавляем продукт в зависимости от выбранного типа
            if (radioButton1.Checked == true)
                VegetableAdd();
            else if (radioButton2.Checked == true)
                FruitAdd();
            else DessertAdd();
        }

        private void VegetableAdd()
        { // создает овощ
            vegetables vegetable = new vegetables();
            vegetable.name = textBox1.Text;
            vegetable.weight = Convert.ToInt32(textBox2.Text);
            vegetable.calories = Convert.ToInt32(textBox3.Text);
            prod = vegetable;
        }
        private void FruitAdd()
        { // создает фрукт
            fruit fr = new fruit();
            fr.name = textBox1.Text;
            fr.capacity = Convert.ToInt32(textBox2.Text);
            fr.vitamins = Convert.ToInt32(textBox3.Text);
            prod = fr;
        }

        private void DessertAdd()
        { // создает десерт
            dessert des = new dessert();
            des.name = textBox1.Text;
            des.calorites = Convert.ToInt32(textBox2.Text);
            des.cacaopercent = Convert.ToInt32(textBox3.Text);
            prod = des;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        { // если сменили тип на десерт
            label2.Text = "Калорийность";
            label3.Text = "% какао";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { // если сменили тип на фрукт
            label2.Text = "Обьем";
            label3.Text = "Витаминов";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { // если сменили тип на овощ
            label2.Text = "Вес";
            label3.Text = "Калорийность";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
