using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.UserDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IUserService
{
    IEnumerable<User> Get();

    User Get(int id);

    User Get(string email, string password);

    void Create(CreateUserDTO model);

    void Edit(int id, EditUserDTO model);

    void Delete(DeleteUserDTO model);
}