﻿namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public Series Series { get; set; }
 
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        { get
            {
                var series = Series;
                if (series != null)
                {
                    return series.Title + " #" + IssueNumber;
                }
                else
                {
                    return null;
                }
            }
        }
        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                var series = Series;
                if (series != null)
                {
                    return series.Title.Replace(" ", "-").ToLower() +
                        "-" + IssueNumber + ".jpg";
                }
                else
                {
                    return null;
                }
            }
        }
    }


}