using Autofac;
using Framework.Services;
using Framework.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Paper
{
    public class AddPaper : PaperBaseModel
    {
        [Required]
        [StringLength(500, MinimumLength = 5)]
        [Display(Name = "Title")]
        public string PaperTilte { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string AuthorName { get; set; }

        public int PaperCategoryId { get; set; }

        public string Volume { get; set; }
        public string Page { get; set; }
        public string ConferenceLocation { get; set; }

        [Required]
        public DateTime Submitdate { get; set; }

        public AddPaper(IPaperDetailsService paperDetailsService) : base(paperDetailsService)
        {

        }

        public AddPaper() : base()
        {

        }

        public IList<SelectListItem> GetCategoryList()
        {
            IList<SelectListItem> listItems = new List<SelectListItem>();
            foreach (var item in _paperDetailsService.GetpaperCategories())
            {
                var ctg = new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                };
                listItems.Add(ctg);
            }
            return listItems;
        }


        public void Add()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            var PaperDetails = new PaperDetails()
            {
                PaperTilte = this.PaperTilte,
                AuthorName = this.AuthorName,
                PaperCategoryId = this.PaperCategoryId,
                Volume = this.Volume,
                Page = this.Page,
                ConferenceLocation = this.ConferenceLocation
            };
            _paperDetailsService.CreatePaperDetails(PaperDetails);

        }
    }
}
