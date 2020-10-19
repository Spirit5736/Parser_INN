using System;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Парс
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
       
        private void Button_StartParsing(object sender, EventArgs e) //кнопка запуска алгоритма парсинга
        {
            if (Inn.Text == "")
            {
                MessageBox.Show(
                    "Введите ИНН",       
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                string dopadress; //новая переменная для ИНН
                dopadress = Inn.Text;
                var html = @"https://zachestnyibiznes.ru/search?query="; //ссылка для добавления адреса из переменной dopadress
                var htmlfirst = html + dopadress; //добавление к ссылке адреса кода ИНН для перехода к интересующей организации
                HtmlWeb web = new HtmlWeb(); //объявление нового экземпляра класса HtmlWeb
                var htmldoc = web.Load(htmlfirst); //загрузка страницы по адресу вида https://zachestnyibiznes.ru/search?query=ИНН       
                var node = htmldoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[4]/div[2]/div/div[3]/table/tbody/tr/td[7]/a"); //выделение необходимого узла в коде страницы        
                string codeofnode = node.OuterHtml; //получение кода узла вида <a href='/company/ul/1147017012119_7017356248_OOO-DEKOST'>смотреть <i class="i-search"></i></a>
                string cutedcodeofnode = codeofnode.Remove(0, 9).Remove(codeofnode[codeofnode.Length - 7]); //получение кода вида "/company/ul/1147017012119_7017356248_OOO-DEKOST"
                var htmlsecond = @"https://zachestnyibiznes.ru"; //ссылка для конечной работы
                var htmlthird = htmlsecond + cutedcodeofnode; //добавление к ссылке адреса кода для перехода к интересующей организации
                HtmlWeb websecond = new HtmlWeb(); //объявление нового экземпляра класса HtmlWeb
                var htmlogrn = websecond.Load(htmlthird); //загрузка страницы по адресу вида https://zachestnyibiznes.ru/company/ul/1147017012119_7017356248_OOO-DEKOST
                var node2 = htmlogrn.DocumentNode.SelectSingleNode("//span[@id='ogrn']"); //выделение узла с ОГРН
                var ogrnresult = node2.InnerHtml; //получение значения ОГРН из узла
                Ogrn.Text = ogrnresult; //отображение в форме полученного ОГРН
                var kpp2 = htmlogrn.DocumentNode.SelectSingleNode("//span[@id='kpp']"); //выделение узла с КПП
                var kppresult = kpp2.InnerHtml; //получение значения КПП из узла
                Kpp.Text = kppresult; //отображение в форме полученного КПП
            }
        }
       
    }
      
}
