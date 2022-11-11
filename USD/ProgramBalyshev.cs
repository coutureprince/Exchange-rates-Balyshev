
// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;
var html = @"https://myfin.by/bank/kursy_valjut_nbrb";
//double usdd;
string data = string.Empty;
HtmlWeb web = new HtmlWeb();
var htmlDoc = web.Load(html);
var nodes = htmlDoc.DocumentNode.SelectNodes($"//*[@id=\"w0\"]/table/tbody/tr[1]/td[2]");
var nodes2 = htmlDoc.DocumentNode.SelectNodes($"//*[@id=\"w0\"]/table/tbody/tr[2]/td[2]");
DateTime today = DateTime.Now;
data = today.Date.ToShortDateString();
if (nodes is not null)
{
    foreach (HtmlNode item in nodes)
    {
        Console.WriteLine("Курс Доллара США на {0} равен {1} руб.", data, item.InnerText.Trim());
    }
    if (nodes2 is not null)
    {
        foreach (HtmlNode item in nodes2)
        {
            Console.WriteLine("Курс Евро на {0} равен {1} руб.", data, item.InnerText.Trim());
        }
    }
}

