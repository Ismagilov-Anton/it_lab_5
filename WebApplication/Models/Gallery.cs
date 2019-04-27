using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Image
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public Image(string name, string link)
        {
            Name = name;
            Link = link;
        }
    }

    public class Gallery
    {
        public string Title { get; set; }

        public List<Image> Images { get; set; }

        public Gallery(string title)
        {
            Title = title;
            Images = new List<Image>();
        }
    }
}
