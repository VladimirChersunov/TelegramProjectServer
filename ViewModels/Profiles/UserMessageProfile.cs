using AutoMapper;
using server.Models;

namespace server.ViewModels.Profiles
{
    public class UserMessageProfile : Profile
    {
        public UserMessageProfile()
        {
            CreateMap<Message, UserMessageViewModel>();
        }
    }
}
