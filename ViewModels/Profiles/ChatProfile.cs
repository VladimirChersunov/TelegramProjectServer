using AutoMapper;
using server.Models;

namespace server.ViewModels.Profiles
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<Chat, ChatViewModel>();
            CreateMap<Chat, ChatUpdateInfoViewModel>();
        }
    }
}
