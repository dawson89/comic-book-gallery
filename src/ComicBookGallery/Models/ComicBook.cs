using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 //Models can contain both attributes and behavors//
 //Typically Modela attributes are defined by using properties
namespace ComicBookGallery.Models
{
	public class ComicBook
	{
		public int Id { get; set; }
		public string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public string DescriptionHtml { get; set; }
		public Artist[] Artists { get; set; }
		public bool Favorite { get; set; }
		public string[] Tags { get; set; }

		//This is readonly because set was not used
		public string DisplayText
		{
			get
			{
				return SeriesTitle + " #" + IssueNumber;
			}
		}
		// series-title-issuenumber.jpg
		public string CoverImageFileName
		{
			get
			{
				return SeriesTitle.Replace(" ", "-")
					.ToLower() + "-" + IssueNumber +  ".jpg";
			}
		}

		

	}
}