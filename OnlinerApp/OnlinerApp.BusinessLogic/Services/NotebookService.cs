using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.NotebookDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class NotebookService : INotebookService
{
    public List<Notebook> Get()
    {
        throw new NotImplementedException();
    }

    public List<Notebook> Get(SortNotebookDTO model)
    {
        throw new NotImplementedException();
    }

    public Notebook Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Create(CreateNotebookDTO model)
    {
        throw new NotImplementedException();
    }

    public void Edit(EditNotebookDTO model)
    {
        throw new NotImplementedException();
    }

    public void Delete(DeleteBasicDTO model)
    {
        throw new NotImplementedException();
    }
}