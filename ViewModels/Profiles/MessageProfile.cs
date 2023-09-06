using AutoMapper;
using server.Models;

namespace server.ViewModels.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<Message, MessageViewModel>();
        }
    }
}
