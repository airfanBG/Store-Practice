using Microsoft.AspNetCore.Mvc.ModelBinding;
using Store.Data.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Data.Common.Services
{
    public static class ModelstateHandler
    {
        public static List<ErrorViewModel> GetErrors(this IEnumerable<KeyValuePair<string, ModelStateEntry>> data)
        {
            var list = new List<ErrorViewModel>();

           // Keys.SelectMany(key => this.ModelState[key].Errors);

            foreach (var item in data.Where(x=>x.Value.Errors.Count()>0).Select(x=>x.Value.Errors))
            {
                list.Add(new ErrorViewModel()
                {
                    ErrorMessage=item.Select(x=>x.ErrorMessage).FirstOrDefault()
                });
            }
            return list;
        }
    }
}
