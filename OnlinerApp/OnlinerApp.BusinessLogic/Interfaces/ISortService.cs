using OnlinerApp.Common.DTO_s;
using OnlinerApp.Model;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface ISortService
{
    IQueryable<BasicModel> Sort(IQueryable<BasicModel> query, SortBasicDTO model);
}