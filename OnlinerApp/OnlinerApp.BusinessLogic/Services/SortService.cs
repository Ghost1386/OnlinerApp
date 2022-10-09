using System.Globalization;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s;
using OnlinerApp.Common.Enums.SortEnum;
using OnlinerApp.Model;

namespace OnlinerApp.BusinessLogic.Services;

public class SortService : ISortService
{
    public IQueryable<BasicModel> Sort(IQueryable<BasicModel> query, SortBasicDTO model)
    {
        if (!string.IsNullOrEmpty(model.Manufacturer))
        {
            query = query.Where(item => model.Manufacturer.Contains(item.Manufacturer));
        }
        
        if (model.Year != 0)
        {
            query = query.Where(item => item.Year == model.Year);
        }

        query = query.Where(item => item.Price >= model.MinPrice);
        
        if (model.MaxPrice != 0)
        {
            query = query.Where(item => item.Price <= model.MaxPrice);
        }

        if (model.SortBy == SortBy.ByPopularity)
        {
            query = query.OrderByDescending(item => model.Popularity);
        }
        
        if (model.SortBy == SortBy.DescendingPrice)
        {
            query = query.OrderByDescending(item => item.Price);
        }
        
        if (model.SortBy == SortBy.AscendingPrice)
        {
            query = query.OrderBy(item => item.Price);
        }
        
        if (model.SortBy == SortBy.ByPopularity)
        {
            query = query.OrderByDescending(item => item.Popularity);
        }
        
        return query;
    }
}