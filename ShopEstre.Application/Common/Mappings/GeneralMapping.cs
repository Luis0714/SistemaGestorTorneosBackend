using AutoMapper;
using ShopEstre.Application.Common.Dtos.Users;
using ShopEstre.Application.Roles.Commands.CreateRol;
using ShopEstre.Application.Roles.Commands.UpdateRol;
using ShopEstre.Application.Users.Commands.Create;
using ShopEstre.Application.Users.Commands.UpdateUser;
using ShopEstre.Domain.Dtos.Rols;
using ShopEstre.Domain.Entities;

namespace ShopEstre.Application.Common.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {

            #region Users
            CreateMap<RegisterUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
            CreateMap<User, UserDto>();
            #endregion

            #region Rols
            CreateMap<CreateRolCommand, Role>();
            CreateMap<UpdateRolCommand, Role>();
            CreateMap<Role, RolDto>();
            #endregion
        }

    }
}
