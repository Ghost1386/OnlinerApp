using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.NotebookDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface INotebookService
{
    IEnumerable<Notebook> Get();

    IQueryable<Notebook> Get(SortNotebookDTO model);

    Notebook Get(int id);

    void Create(CreateNotebookDTO model);

    void Edit(int id, EditNotebookDTO model);

    void Delete(DeleteBasicDTO model);
}