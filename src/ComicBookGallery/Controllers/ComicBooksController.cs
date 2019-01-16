using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		public ActionResult Detail()
		{
			//Strongly Typed views
			//OPTION ONE
			//var comicBook = new ComicBook();
			//comicBook.SeriesTitle = "The Amazing Spider-Man";
			//OPTION TWO - Object Initailizing Syntax
			var comicBook = new ComicBook()
			{
				SeriesTitle = "The Amazing Spider-Man",
				IssueNumber = 700,
				DescriptionHtml = "<p>Final issue!Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
				Artists = new Artist[]
				{
					new Artist() { Name = "Dan Slott", Role = "Script" },
					new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
					new Artist() { Name = "Victor Olazaba", Role = "Inks" },
					new Artist() { Name = "Edgar Delgado", Role = "Colors" },
					new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
				},
				Tags = new Tag[]
				{
					new Tag() { Category = "Comedy" },
					new Tag() { Category = "Horror" },
					new Tag() { Category = "Foreign" },
					new Tag() { Category = "Sci-Fy" },
					new Tag() { Category = "Fiction" },

				}
			};

			//ViewBag.SeriesTitle = "The Amazing Spider-Man";
			//	ViewBag.IssueNumber = 700;
			//	ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
			//	ViewBag.Artists = new string[]
			//	{
			//		"Script: Dan Slott",
			//		"Pencils: Humberto Ramos",
			//		"Inks: Victor Olazaba",
			//		"Colors: Edgar Delgado",
			//		"Letters: Chris Eliopoulos"
			//	};
			//	ViewBag.Tags = new string[]
			//	{
			//		"Comedy",
			//		"Horror",
			//		"Foreign",
			//		"Sci-Fi",
			//		"Fiction"
			//	};

			//Passing the Model Instance into out view method call this makes the view strongly typed
			return View(comicBook);
		}
	}
}