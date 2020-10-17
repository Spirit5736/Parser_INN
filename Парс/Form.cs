using System;
using HtmlAgilityPack;

namespace Парс
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Label_WriteInn(object sender, EventArgs e) //"Введите ИНН организации"
        {

        }

        private void Button_StartParsing(object sender, EventArgs e) //кнопка запуска алгоритма парсинга
        {
            string dopadress; //новая переменная для ИНН
            dopadress = Inn.Text; //присвоение переменной введенному ИНН из Inn_TextForParsing
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
            var htmlogrn = websecond.Load(htmlthird);
            var node2 = htmlogrn.DocumentNode.SelectSingleNode("//span[@id='ogrn']");
            var ogrnresult = node2.InnerHtml;
            Ogrn.Text = ogrnresult;
            var kpp2 = htmlogrn.DocumentNode.SelectSingleNode("//span[@id='kpp']");
            var kppresult = kpp2.InnerHtml;
            Kpp.Text = kppresult;
        }

        private void Inn_TextForParsing(object sender, EventArgs e) //строка для введения ИНН для последующего парсинга
        {
            
        }

        private void Ogrn_ResultOfParsing(object sender, EventArgs e) //строка для отображения найденного ОГРН
        {

        }

        private void Label_WriteKpp(object sender, EventArgs e) //текст "КПП организации"
        {

        }       
     

        private void Form_Load(object sender, EventArgs e) //непосредственно сама форма
        {

        }

        private void Ready_ogrn_Click(object sender, EventArgs e) //текст "ОГРН организации"
        {

        }

        private void Kpp_ResultOfParsing(object sender, EventArgs e) //строка для отображения найденного КПП
        {

        }
    }
}
