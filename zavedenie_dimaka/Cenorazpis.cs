using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavedenie_dimaka
{
    public partial class cenorazpis : Form
    {
        public cenorazpis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double shopska, mlechna, turshiq, kebapche, kartof, agneshko,
            sok ,kola, voda, rakiq, uiski, vodka, grshokolad, chai, grrakiq, torta, sladoled, krem, total = 0.00;
            if (double.TryParse(textBox1.Text, out shopska) && shopska > 0)
            {
                total += shopska * 5.50;
            }
            if (double.TryParse(textBox2.Text, out mlechna) && mlechna > 0)
            {
                total += mlechna * 6.00;
            }
            if (double.TryParse(textBox3.Text, out turshiq) && turshiq > 0)
            {
                total += turshiq * 4.00;
            }
            if (double.TryParse(textBox4.Text, out kebapche) && kebapche > 0)
            {
                total += kebapche * 2.00;
            }
            if (double.TryParse(textBox5.Text, out kartof) && kartof > 0)
            {
                total += kartof * 4.00;
            }
            if (double.TryParse(textBox6.Text, out agneshko) && agneshko > 0)
            {
                total += agneshko * 12.00;
            }
            if (double.TryParse(textBox7.Text, out sok) && sok > 0)
            {
                total += sok * 2.50;
            }
            if (double.TryParse(textBox8.Text, out kola) && kola > 0)
            {
                total += kola * 3.00;
            }
            if (double.TryParse(textBox9.Text, out voda) && voda > 0)
            {
                total += voda * 2.00;
            }
            if (double.TryParse(textBox10.Text, out rakiq) && rakiq > 0)
            {
                total += rakiq * 6.00;
            }
            if (double.TryParse(textBox11.Text, out uiski) && uiski > 0)
            {
                total += uiski * 8.00;
            }
            if (double.TryParse(textBox12.Text, out vodka) && vodka > 0)
            {
                total += vodka * 7.00;
            }
            if (double.TryParse(textBox13.Text, out grshokolad) && grshokolad > 0)
            {
                total += grshokolad * 3.50;
            }
            if (double.TryParse(textBox14.Text, out chai) && chai > 0)
            {
                total += chai * 1.50;
            }
            if (double.TryParse(textBox15.Text, out grrakiq) && grrakiq > 0)
            {
                total += grrakiq * 5.00;
            }
            if (double.TryParse(textBox17.Text, out torta) && torta > 0)
            {
                total += torta * 4.50;
            }
            if (double.TryParse(textBox16.Text, out sladoled) && sladoled > 0)
            {
                total += sladoled * 3.50;
            }
            if (double.TryParse(textBox18.Text, out krem) && krem > 0)
            {
                total += krem * 2.00;
            }
            
            Console.WriteLine("Моля изберете начин на плащане:");
            Console.WriteLine("1. Кеш");
            Console.WriteLine("2. Карта");
            Console.Write("Твоя избор е: ");
            string plashtane = Console.ReadLine();
            if (plashtane == "Кеш")
            {
                Console.WriteLine("Плащането ще бъде извършено в брой.");
                Console.WriteLine("Ще оставите ли бакшиш?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Не");
                Console.Write("Твоя избор е номер: ");
                int bakshish = int.Parse(Console.ReadLine());
                if (bakshish == 1)
                {
                    Console.WriteLine("Колко ще оставиш?");
                    double bakshish1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Благодарим Ви за бакшиша!");
                }
                if (bakshish == 2)
                {
                    Console.WriteLine("Благодарим Ви, че посетихте нашия ресторант! Желаем Ви приятнен ден!");
                }
            }
            if (plashtane == "Карта")
            {
                Console.WriteLine("Моля поставете картата си в устройството за плащане.");
            }
            MessageBox.Show($"Общата сума е: {total} лв. \n Начин на плащане: {plashtane}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Poruchka poruchka = new Poruchka();
            poruchka.Show();
            poruchka.BringToFront();
            
        }
    }
}
