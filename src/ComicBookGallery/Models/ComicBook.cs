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

	}
}