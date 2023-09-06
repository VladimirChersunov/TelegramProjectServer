using AutoMapper;
using server.Models;

namespace server.ViewModels.Profiles
{
    public class MessageViewProfile : Profile
    {
        public MessageViewProfile()
        {
            CreateMap<MessageView, MessageViewModel>();
        }
    }
}
