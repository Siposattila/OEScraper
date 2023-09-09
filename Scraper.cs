using System.Collections.Generic;
using HtmlAgilityPack;

namespace OEScraper
{
    internal class Scraper
    {
        private HtmlWeb web;
        private string url = "https://uni-obuda.hu/telefonkonyv/?cont_name=";

        public Scraper(string? name)
        {
            this.web = new HtmlWeb();
            this.url += name;
        }

        public List<ContactData> Scrape()
        {
            List<ContactData> contactDataResult = new List<ContactData>();
            HtmlDocument document = this.web.Load(this.url);
            HtmlNodeCollection resultNodes = document.DocumentNode.SelectNodes("//*[@class='contact-inner']");

            foreach (HtmlNode node in resultNodes)
            {
                ContactData contactData = new ContactData();
                contactData.Name = node.SelectSingleNode("./*[@class='name']").InnerText;
                contactData.Title = node.SelectSingleNode("./*[@class='title']").InnerText;
                contactData.Department = node.SelectSingleNode("./*[@class='department']").InnerText;
                contactData.Telephone = node.SelectSingleNode("./*[@class='telephone']").InnerText;
                contactData.Email = node.SelectSingleNode("./*[@class='mail']").InnerText;
                contactData.Address = node.SelectSingleNode("./*[@class='address']").InnerText;

                contactDataResult.Add(contactData);
            }

            return contactDataResult;
        }
    }
}
