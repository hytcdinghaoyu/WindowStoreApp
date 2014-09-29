using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Windows.Data.Json;
using Windows.Data.Xml.Dom;
using Windows.Data.Xml.Xsl;
using Windows.Storage;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;



namespace MyFirstApp.DataModel
{
    public class NewsDataItem
    {
        public NewsDataItem(String uid, String title, String description, String imgpath, String link, String pubDate, String author)
        {
            this.Uid = uid;
            this.Title = title;
            this.Description = description;
            this.ImgPath = imgpath;
            this.Link = link;
            this.PubDate = pubDate;
            this.Author = author;
        }
        public NewsDataItem()
        {

        }
        public string Uid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public string Link { get; set; }
        public string PubDate { get; set; }
        public string Author { get; set; }
    }

    public class NewsDataGroup
    {
        public NewsDataGroup()
        {
            this.Items = new ObservableCollection<NewsDataItem>();
        }
        public ObservableCollection<NewsDataItem> Items { get; set; }

    }
    class NewsDataSource
    {
        private static NewsDataSource _sampleDataSource = new NewsDataSource();

        private ObservableCollection<NewsDataGroup> _groups = new ObservableCollection<NewsDataGroup>();
        public ObservableCollection<NewsDataGroup> Groups
        {
            get { return this._groups; }
        }

    }
}
