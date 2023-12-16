using DotNet5CRUD.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet5CRUD.ViewModels
{
	public class MovieFormViewModel
	{
		[Required, StringLength(250)]
		public string Title { get; set; }
		public int Year { get; set; }
		[Range(1,10)]
		public double Rate { get; set; }
		[Required, StringLength(2500)]
		public string Storeline { get; set; }
		
		public byte[] Poster { get; set; }
		[Display(Name ="Genre")]
		public byte GenreId { get; set; } // Navigational Property

		public IEnumerable<Genre> Genres { get; set; }
	}
}
