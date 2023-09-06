using AutoMapper;
using server.Models;

namespace server.ViewModels.Profiles
{
    public class UserContactProfile : Profile
    {
        public UserContactProfile()
        {
            CreateMap<UserContact, UserContactViewModel>();
        }
    }
}
