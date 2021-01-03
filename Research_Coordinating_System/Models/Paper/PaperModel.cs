using Framework.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Paper
{
    public class PaperModel : PaperBaseModel
    {
        public PaperModel(IPaperDetailsService paperDetailsService) : base(paperDetailsService)
        {

        }

        public PaperModel() : base()
        {

        }

        internal object GetPaperDetails(DataTablesAjaxRequestModel dataTables)
        {
            var data = _paperDetailsService.GetPaperDetails(
                                        dataTables.PageIndex,
                                        dataTables.PageSize,
                                        dataTables.SearchText,
                                        dataTables.GetSortText(new string[] { "PaperTilte", "AuthorName" }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.paperDetails
                        select new string[]
                        {
                            record.PaperTilte,
                           
                            record.AuthorName
                        }).ToArray()
            };
        }
    }
}
