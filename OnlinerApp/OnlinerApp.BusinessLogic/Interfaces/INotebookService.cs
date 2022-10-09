using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.NotebookDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface INotebookService
{
    List<Notebook> Get();

    List<Notebook> Get(SortNotebookDTO model);

    Notebook Get(int id);

    void Create(CreateNotebookDTO model);

    void Edit(EditNotebookDTO model);

    void Delete(DeleteBasicDTO model);
}