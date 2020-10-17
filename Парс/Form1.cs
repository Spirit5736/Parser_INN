using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Парс
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dopadress;
            dopadress = Inn.Text;
            var html = @"https://zachestnyibiznes.ru/search?query="; //ссылка для добавления адреса из переменной dopadress
            var htmlfirst = html + dopadress;            
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(htmlfirst);

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            var node = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[4]/div[2]/div/div[3]/table/tbody/tr/td[7]/a");
            //Ogrn.Text = "Node Name: " + node.Name + "\n" + node.OuterHtml;
            //string item = node.SelectSingleNode("//a").Attributes["href"].Value;
            string linktwo = node.OuterHtml;
            linktwo = linktwo.Remove(0, 9).Remove(linktwo[linktwo.Length - 7]);
            var htmlsecond = @"https://zachestnyibiznes.ru"; //ссылка для конечной работы
            var htmlthird = htmlsecond + linktwo;
            HtmlWeb websecond = new HtmlWeb();
            var htmlOgrn = websecond.Load(htmlthird);
            var node2 = htmlOgrn.DocumentNode.SelectSingleNode("//span[@id='ogrn']");
            var ogrn = node2.InnerHtml;
            Ogrn.Text = ogrn;
            var kpp2 = htmlOgrn.DocumentNode.SelectSingleNode("//span[@id='kpp']");
            var kpp = kpp2.InnerHtml;
            textBox1.Text = kpp;
        }

        private void Inn_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void Ogrn_TextChanged(object sender, EventArgs e)
        {
            
                

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kpp(object sender, EventArgs e)
        {
            
        }
    }
}
