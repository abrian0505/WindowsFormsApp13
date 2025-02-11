using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {

        byte lng = 1;
        byte capsl = 0;
        char[] rusbez = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', '\\', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю', '.' };
        char[] russ = { '!', '"', '№', ';', '%', ':', '?', '*', '(', ')', '_', '+', 'Й', 'Ц', 'У', 'К', 'Е', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Х', 'Ъ', '/', 'Ф', 'Ы', 'В', 'А', 'П', 'Р', 'О', 'Л', 'Д', 'Ж', 'Э', 'Я', 'Ч', 'С', 'М', 'И', 'Т', 'Ь', 'Б', 'Ю', ',' };
        char[] engbez = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', '[', ']', '\\', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', ';', '\'', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.', '/' };
        char[] engs = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', '{', '}', '|', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', ':', '"', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '<', '>', '?' };
        char[] raskl;

        
        public Form1()
        {
            InitializeComponent();
            button8.Visible = false;
            textBox1.Visible = false;
            groupBox5.Visible = false;
            button9.Visible= false;
            button10.Visible= false;
            button11.Visible= false;
        }




        // tX_Click - кнопки клавиатуры
        private void t0_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t0.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t1_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t1.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t2_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t2.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t3_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t3.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t4_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t4.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t5_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t5.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t6_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t6.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t7_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t7.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t8_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t8.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t9_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t9.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t10_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t10.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t11_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t11.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t12_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t12.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t13_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t13.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t14_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t14.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t15_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t15.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t16_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t16.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t17_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t17.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t18_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t18.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t19_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t19.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t20_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t20.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t21_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t21.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t22_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t22.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t23_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t23.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t24_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t24.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t25_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t25.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t26_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t26.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t27_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t27.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t28_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t28.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t29_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t29.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t30_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t30.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t31_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t31.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t32_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t32.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t33_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t33.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t34_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t34.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t35_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t35.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t36_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t36.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t37_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t37.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t38_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t38.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t39_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t39.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t40_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t40.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t41_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t41.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t42_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t42.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t43_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t43.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t44_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t44.Text);
            richTextBox1.ReadOnly = true;
        }

        private void t45_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(t45.Text);
            richTextBox1.ReadOnly = true;
        }



        public void qwerty()// метод смены текста клавиш в зависимости от включения caps и выбора языка
        {
            if (lng == 0 & capsl==1 ) { raskl = russ; }
            else if (lng==1  & capsl==1) { raskl = engs; }
            else if (lng==1 & capsl==0) { raskl = engbez; }
            else if (lng ==0 & capsl==0) { raskl = rusbez; }
            for (int i = 0; i <45; i++)
            {
                string bn = "t" + i;
                Button button = this.Controls.Find(bn, true).FirstOrDefault() as Button;
                button.Text = Convert.ToString(raskl[i]);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//eng 
        {
            if (radioButton2.Checked) { lng = 1; }
            qwerty();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//rus
        {
            if (radioButton1.Checked) { lng = 0; }
            qwerty();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//capslock on
        {
            if (radioButton3.Checked) { capsl = 1; }
            qwerty();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//capslock off
        {
            if (radioButton4.Checked) { capsl = 0; }
            qwerty();
        }

        private void button1_Click(object sender, EventArgs e) // backspace
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait("{BACKSPACE}");
            richTextBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e) // enter
        {
            richTextBox1.Text += "\n";
        }

        private void button4_Click(object sender, EventArgs e) // strelka vpravo
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            richTextBox1.SelectionStart++;
            richTextBox1.ReadOnly = true;

        }

        private void button3_Click(object sender, EventArgs e) // strelka vlevo
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            if (richTextBox1.SelectionStart > 0)
            {
                richTextBox1.SelectionStart--;
            }
            richTextBox1.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e) // save
        { 
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить";
            save.Filter = "RTF|*.rtf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void open_Click(object sender, EventArgs e)//open
        {
            OpenFileDialog open = new OpenFileDialog();   
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
            }

        }

        private void button5_Click_1(object sender, EventArgs e) //fonts 
        {
            FontDialog fontDialog = new FontDialog
            {
                Font = richTextBox1.SelectionFont
            };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void button6_Click(object sender, EventArgs e) // polzovatelsk
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            button5.Visible = false;
            textBox1.Visible = true;
            button8.Visible= true; 
            groupBox5.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e) // obichn
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox4.Visible = true;
            button5.Visible = true;
            groupBox5.Visible = false;
            button8.Visible=false; 
            textBox1.Visible = false;
            button9.Visible = false;
        }
        byte count = 0;
        private void button8_Click(object sender, EventArgs e)// добавить кнопку
        {
            if (textBox1.Text.Length > 0)
            {
                if (count == 0)    { p1.Text = textBox1.Text; count++; }
                else if (count==1) { p2.Text = textBox1.Text; count++; }
                else if (count==2) { p3.Text = textBox1.Text; count++; }
                else if (count==3) { p4.Text = textBox1.Text; count++; }
                else if (count==4) { p5.Text = textBox1.Text; count++; }
                else
                {
                    MessageBox.Show("Вы добавили максимально возможное количество клавиш");
                }


            }
            else { MessageBox.Show("Сначала введите в поле ниже текст, который будет использоваться в кнопке"); }
        }

        private void p1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(p1.Text);
        }

        private void p2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(p2.Text);
        }

        private void p3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(p3.Text);
        }

        private void p4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText (p4.Text);
        }

        private void p5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(p5.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            p5.Text = "";
            count = 0;

        }

        private void probel_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Focus();
            SendKeys.SendWait(" ");
            richTextBox1.ReadOnly = true;
        }
        private void SaveLayout(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(p1.Text);
                writer.WriteLine(p2.Text);
                writer.WriteLine(p3.Text);
                writer.WriteLine(p4.Text);
                writer.WriteLine(p5.Text);
            }
        }

        private void LoadLayout(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    p1.Text = reader.ReadLine();
                    p2.Text = reader.ReadLine();
                    p3.Text = reader.ReadLine();
                    p4.Text = reader.ReadLine();
                    p5.Text = reader.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы|*.txt"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveLayout(saveFileDialog.FileName);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadLayout(openFileDialog.FileName);
            }
        }
    }
}
