using OnlinerApp.Common.DTO_s.AuthDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IAuthService
{
    string Login(AuthUserDTO model);

    void Register(RegisterUserDTO model);
}