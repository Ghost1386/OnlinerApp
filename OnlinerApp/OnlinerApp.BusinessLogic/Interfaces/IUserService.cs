using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.UserDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IUserService
{
    List<User> Get();

    User Get(int id);

    void Create(CreateUserDTO model);

    void Edit(EditUserDTO model);

    void Delete(DeleteUserDTO model);
}