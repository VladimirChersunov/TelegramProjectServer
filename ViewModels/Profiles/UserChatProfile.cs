using AutoMapper;
using server.Models;

namespace server.ViewModels.Profiles
{
    public class UserChatProfile : Profile
    {
        public UserChatProfile()
        {
            CreateMap<UserChat, UserChatViewModel>();
        }
    }
}
