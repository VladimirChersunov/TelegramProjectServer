using Microsoft.EntityFrameworkCore;
using server.Helpers;
using server.Models;
using System;

namespace server
{
    public class ApplicationContext : DbContext
    {
        private PhotosContainer? _container;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated(); // create db
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _container = new PhotosContainer();
            //===================================================relationships

            //=====================one-to-many

            modelBuilder.Entity<UserContact>() // one user has many contacts
                .HasOne(u => u.User)
                .WithMany(c => c.UserContacts)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<User>() // one member has many users
                .HasOne(u => u.Member)
                .WithMany(c => c.User)
                .HasForeignKey(c => c.MemberId);

            modelBuilder.Entity<Member>() // one member has many users
                .HasOne(u => u.Role)
                .WithMany(c => c.Members)
                .HasForeignKey(c => c.RoleId);

            //=====================many-to-many
            modelBuilder.Entity<UserSetting>().HasKey(us => new { us.UserId, us.SettingId }); // many users to many settings
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId }); // many users to many roles
            // many users to many chats
            modelBuilder.Entity<UserChat>().HasKey(ug => new { ug.UserId, ug.ChatId}); 
            modelBuilder.Entity<UserChat>()
                .HasOne<User>(sc=>sc.User)
                .WithMany(s=>s.UserChats)
                .HasForeignKey(s=>s.UserId);

            modelBuilder.Entity<UserChat>()
                .HasOne<Chat>(sc=>sc.Chat)
                .WithMany(s=>s.UserChats)
                .HasForeignKey(s=>s.ChatId);

            modelBuilder.Entity<ChatMessage>().HasKey(cm => new { cm.ChatId, cm.MessageId });
            modelBuilder.Entity<MessageView>().HasKey(cm => new { cm.UserId, cm.MessageId }); // many users to many messages
            modelBuilder.Entity<ChatMute>().HasKey(cm => new { cm.UserId, cm.ChatId }); // many users to many chats

            //users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 745,
                    UserName = "System",
                    Age = 1,
                    Email = "novikov.aleks1205@gmail.com",
                    Password = HashHelper.HashPassword("systemcryptic"),
                    MemberId = 1,
                    LastOnline = DateTime.Now,
                    Photo = null
                },
                new User { Id = 1, UserName = "vlad1or", Age = 20, Email = "vlad1or@i.ua", Password = HashHelper.HashPassword("qwrg25"), MemberId=1,LastOnline = DateTime.Now,
                Photo = _container.VladiorImage
                },
                new User { Id = 2, UserName = "olgerd17", Age = 23, Email = "oleg1665@i.ua", Password = HashHelper.HashPassword("612ss4t2"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Olgerd17Image
                },
                new User {Id = 3, UserName = "Vertegro", Age = 27, Email = "vergiliy@gmail.com", Password = HashHelper.HashPassword("kuiy235"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.VertegroImage
                },
                new User {Id = 4, UserName = "liokSinner", Age = 20, Email = "dante@gmail.com", Password = HashHelper.HashPassword("antanta13"), MemberId = 1 , LastOnline = DateTime.Now,
                    Photo = _container.LiokSinnerImage
                },
                new User {Id = 5, UserName = "jackKcaj", Age = 19, Email = "jolloj@gmail.com", Password = HashHelper.HashPassword("solieri"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.JackKcajImage
                },
                new User {Id = 6, UserName = "kntrl552", Age = 25, Email = "kentrol@gmail.com", Password = HashHelper.HashPassword("alsss54"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Kntrl552Image
                },
                new User { Id = 7, UserName = "Leared", Age = 27, Email = "DeanneJMcNeel@dayrep.com", Password = HashHelper.HashPassword("anagh2Vu3"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.LearedImage
                },
                new User { Id = 8, UserName = "Whictime", Age = 37, Email = "RubenJWatsonl@armyspy.com", Password = HashHelper.HashPassword("voosau5Th"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.WhictimeImage
                },
                new User { Id = 9, UserName = "Scance2000", Age = 22, Email = "KevinLHathaway@rhyta.com", Password = HashHelper.HashPassword("Neiyi5chooTh"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Scance2000Image
                },
                new User { Id = 10, UserName = "Aday1994", Age = 28, Email = "MarioJNewell@jourrapide.com", Password = HashHelper.HashPassword("Uy1poHeusu"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Aday1994Image
                },
                new User { Id = 11, UserName = "Amine1980", Age = 43, Email = "CharlesABrunson@rhyta.com", Password = HashHelper.HashPassword("SuTee3ohNg"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Amine1980Image
                },
                new User { Id = 12, UserName = "Havaily", Age = 42, Email = "MaryJCangelosi@dayrep.com", Password = HashHelper.HashPassword("av7pahDi9Iz"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.HavailyImage
                },
                new User { Id = 13, UserName = "Upoinfor", Age = 24, Email = "ChristopherJHoward@armyspy.com", Password = HashHelper.HashPassword("aaRue0az"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.UpoinforImage
                },
                new User { Id = 14, UserName = "Andow1994", Age = 28, Email = "DanielLBrumit@dayrep.com", Password = HashHelper.HashPassword("Uc3Oa0uyai6"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Andow1994Image
                },
                new User { Id = 15, UserName = "Donew1987", Age = 35, Email = "JustinGRios@rhyta.com", Password = HashHelper.HashPassword("diiM1niez"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Donew1986Image
                },
                new User { Id = 16, UserName = "Birear", Age = 39, Email = "JosephJFaulkner@teleworm.us", Password = HashHelper.HashPassword("Phixah2yeeTh"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.BirearImage
                },
                new User { Id = 17, UserName = "Yetrome1992", Age = 30, Email = "LeeBHammes@armyspy.com", Password = HashHelper.HashPassword("oong8eeMu3o"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.Yetrome1992Image
                },
                new User { Id = 18, UserName = "Proothe", Age = 17, Email = "StevenARoss@rhyta.com", Password = HashHelper.HashPassword("ohQu0aic"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.ProotheImage
                },
                new User { Id = 19, UserName = "Lifeare", Age = 41, Email = "MindyCDiaz@rhyta.com", Password = HashHelper.HashPassword("kukeig0aiY"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.LifeareImage
                },
                new User { Id = 20, UserName = "Indess", Age = 22, Email = "JacquelineCTucker@teleworm.us", Password = HashHelper.HashPassword("Oxais2ixah"), MemberId = 1, LastOnline = DateTime.Now,
                    Photo = _container.IndessImage
                }
                );
            
            //roles
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name ="User"}, new Role { Id = 2, Name = "Admin"});
            //members
            modelBuilder.Entity<Member>().HasData(new Member { Id = 1, RoleId =1},new Member { Id = 2, RoleId =2});
            //chats
            modelBuilder.Entity<Chat>().HasData(
                new Chat { Id = 1, ChatInfo ="First group of cryptic", ChatName="FIRST", PublishTime = DateTime.Now.Subtract(new TimeSpan(15, 4, 10, 9, 40, 15)), ChatImage =_container.FirstImage, MembersCount=3, ShortMessage= "Vertegro:He is sleeping, dumbass", AuthorId=1, Type="Group"},
                 new Chat { Id = 2, ChatInfo = "Chat GPT 3 fans only", ChatName = "openai fun club",   ChatImage = _container.OpenAiFunClubImage, MembersCount = 1, ShortMessage = "empty...", AuthorId = 2, Type = "Group" },
                 new Chat { Id = 3, ChatInfo = "Cool channel", ChatName = "Programming news", PublishTime = DateTime.Now.Subtract(new TimeSpan(10, 4, 10, 9, 40, 15)), ChatImage = _container.ProgrammingNewsImage, MembersCount = 2, ShortMessage = "liokSinner:This is start of this channel, welcome everyone!", AuthorId = 2, Type = "Channel" },
                new Chat { Id = 4, PublishTime = DateTime.Now.Subtract(new TimeSpan(2023, 4, 15, 9, 39, 0)), MembersCount = 2, ShortMessage = "olgerd17: DONT IGNORE ME!!!!!", AuthorId = 2, Type = "Private" },
                new Chat { Id = 5, PublishTime= DateTime.Now.Subtract(new TimeSpan(2023, 4, 17, 22, 10, 15)), MembersCount = 2, ShortMessage = "jackKcaj:yo, bro, wassup", AuthorId = 5, Type = "Private"},
                //==============================================saved messages chats
                new Chat { Id = 6, PublishTime= DateTime.Now.Subtract(new TimeSpan(13, 4, 5, 9, 40, 15)), MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 1, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 7,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 2, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 8,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 3, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 9,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 4, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 10,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 5, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 11,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 6, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 12,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 7, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 13,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 8, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 14,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 9, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 15,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 10, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 16,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 11, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 17,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 12, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 18,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 13, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 19,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 14, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 20,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 15, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 21,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 16, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 22,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 17, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 23,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 18, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 24,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 19, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                new Chat { Id = 25,   MembersCount = 1, ChatName = "Saved Messages", ShortMessage = "Saved Message", AuthorId = 20, Type = "Favorite", ChatImage = _container.SavedMessageImage },
                //==============================================groups
                new Chat { Id = 26, ChatInfo = "Chat for tech enthusiasts", ChatName = "Geek Squad",   ChatImage = _container.GeekSquadImage, MembersCount = 5, ShortMessage = "Vertegro:I think it's a great game with a lot of potential. The bugs and glitches can be frustrating, but I'm sure they'll get fixed with time.", AuthorId = 5, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(10, 5, 5, 10, 50, 15)) },
                new Chat { Id = 27, ChatInfo = "Chat for music lovers", ChatName = "Music Mania",   ChatImage = _container.MusicManiaImage, MembersCount = 10, ShortMessage = "Lifeare:I'm a fan of Jazz and Blues.", AuthorId = 7, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(19, 7, 27, 10, 50, 15)) },

                new Chat { Id = 28, ChatInfo = "Chat for bookworms", ChatName = "Book Club",   ChatImage = _container.BookClubImage, MembersCount = 8, ShortMessage = "olgerd17:I'm looking for a good mystery novel to read. Any recommendations?", AuthorId = 9, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(5, 12, 29, 10, 50, 15)) },

                new Chat { Id = 29, ChatInfo = "Chat for movie buffs", ChatName = "Film Fanatics",   ChatImage = _container.FilmFanaticsImage, MembersCount = 7, ShortMessage = "kntrl552:I love \"The Godfather.\" It's a classic.", AuthorId = 3, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(15, 2, 4, 10, 50, 15)) },

                new Chat { Id = 30, ChatInfo = "Chat for sports enthusiasts", ChatName = "Sports Talk",   ChatImage = _container.SportsTalkImage, MembersCount = 12, ShortMessage = "kntrl552:I support the New England Patriots in the NFL.", AuthorId = 13, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(3, 4, 1, 10, 50, 15)) },

                new Chat { Id = 31, ChatInfo = "Chat for foodies", ChatName = "Foodies Unite",   ChatImage = _container.FoodiesUniteImage, MembersCount = 6, ShortMessage = "olgerd17:I love Italian food. Pasta is my weakness.", AuthorId = 16, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(15, 11, 32, 10, 50, 15)) },

                new Chat { Id = 32, ChatInfo = "Chat for travel enthusiasts", ChatName = "Wanderlust",   ChatImage = _container.WanderlustImage, MembersCount = 9, ShortMessage = "kntrl552:I want to visit Machu Picchu in Peru.", AuthorId = 1, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(4, 6, 27, 10, 50, 15)) },

                new Chat { Id = 33, ChatInfo = "Chat for pet lovers", ChatName = "Furry Friends",  ChatImage = _container.FurryFriendsImage, MembersCount = 4, ShortMessage = "olgerd17:I love cats. They're so independent and cute.", AuthorId = 14, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(9, 9, 19, 10, 50, 15)) },

                new Chat { Id = 34, ChatInfo = "Chat for art enthusiasts", ChatName = "Art Lovers",  ChatImage = _container.ArtLoversImage, MembersCount = 3, ShortMessage = "Vertegro:I love impressionism. The use of light and color is so beautiful.", AuthorId = 18, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 14, 10, 50, 15)) },

                new Chat { Id = 35, ChatInfo = "Chat for fitness enthusiasts", ChatName = "Fitness Fanatics",  ChatImage = _container.FitnessFanaticsImage, MembersCount = 11, ShortMessage = "Vertegro:I prefer to lift weights at the gym. It's a great way to build strength and muscle.", AuthorId = 17, Type = "Group", PublishTime = DateTime.Now.Subtract(new TimeSpan(6, 7, 11, 10, 50, 15)) },

                //==============================================channels
               new Chat { Id = 36, ChatInfo = "Latest tech updates", ChatName = "TechTrends",  ChatImage = _container.TechTrendsImage, MembersCount = 4, ShortMessage = "TechTrends:The Rise of Artificial Intelligence in Healthcare: How AI is Revolutionizing the Industry\" - From diagnosing diseases to developing new treatments, artificial intelligence is changing the face of healthcare. In this post, we'll explore the latest developments in AI technology and how they are being applied in the medical field.", AuthorId = 14, Type = "Channel",PublishTime = DateTime.Now.Subtract(new TimeSpan(18, 4, 11, 10, 50, 15)) },
                new Chat { Id = 37, ChatInfo = "Healthy lifestyle tips", ChatName = "FitLife",  ChatImage = _container.FitLifeImage, MembersCount = 7, ShortMessage = "FitLife:The Benefits of Yoga: Why You Should Incorporate This Practice Into Your Life\" - Yoga is more than just a physical exercise. In this post, we'll dive into the many benefits of yoga, from reducing stress and anxiety to improving flexibility and balance.", AuthorId = 10, Type = "Channel", PublishTime = DateTime.Now.Subtract(new TimeSpan(10, 7, 25, 10, 50, 15)) },

                new Chat { Id = 38, ChatInfo = "Daily dose of inspiration", ChatName = "MotivationalQuotes",  ChatImage = _container.MotivationalQuotesImage, MembersCount = 5, ShortMessage = "MotivationalQuotes:The Power of Positive Thinking: How Your Mindset Can Change Your Life\" - Your thoughts have a powerful impact on your life. In this post, we'll explore the concept of positive thinking and how it can help you achieve your goals and live a happier life.", AuthorId = 19, Type = "Channel", PublishTime = DateTime.Now.Subtract(new TimeSpan(4, 15, 21, 10, 50, 15)) },

                new Chat { Id = 39, ChatInfo = "Travel destination ideas", ChatName = "WanderlustTravel",  ChatImage = _container.WanderlustTravelImage, MembersCount = 9, ShortMessage = "WanderlustTravel:Sustainable Travel: How to Reduce Your Environmental Impact While Exploring the World\" - Traveling can have a significant impact on the environment. In this post, we'll share tips for traveling sustainably, from packing eco-friendly products to supporting local businesses.", AuthorId = 15, Type = "Channel" , PublishTime = DateTime.Now.Subtract(new TimeSpan(14, 2, 14, 10, 50, 15))},

                new Chat { Id = 40, ChatInfo = "Entertainment news", ChatName = "HollywoodBuzz",  ChatImage = _container.HollywoodBuzzImage, MembersCount = 12, ShortMessage = "HollywoodBuzz:Celebrity Style: Get Inspired by the Latest Fashion Trends From Your Favorite Stars\" - Whether you're a fashionista or just looking for some style inspiration, celebrity fashion can be a great source of ideas. In this post, we'll share some of the latest fashion trends from the red carpet and beyond.", AuthorId = 20, Type = "Channel", PublishTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 21, 10, 50, 15)) },
                //==============================================private conversations
                //birear(16) upoinfor(13)
                new Chat { Id = 41, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Birear:I might go for a hike if the weather is nice. It's been a while since I've been out in nature.", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(21, 4, 58, 10, 50, 15)) },
                //vertegro(3) scance2000(9)
                new Chat { Id = 42, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Scance2000:Actually, I just got back from a trip to Japan. It was amazing.", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 2, 10, 50, 15)) },
                //havaily(12) donew1987(15)
                new Chat { Id = 43, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Donew1987:Yeah, I just watched the new Spiderman movie. It was pretty good.", AuthorId = null, Type = "Private", PublishTime =  DateTime.Now.Subtract(new TimeSpan(5, 11, 11, 10, 50, 15)) },
                //jackKcaj(5) indess(20)
                new Chat { Id = 44, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "jackKcaj:Yeah, I've been playing a lot of Apex Legends. It's a really fun game.", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 21, 10, 50, 15)) },
                //leared(7) whictime(8)
                new Chat { Id = 45, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Leared:That sounds interesting, I might have to check it out sometime. Thanks for the recommendation!", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(23, 1, 42, 10, 50, 15)) },
                //proothe(18) yetrome1992(17)
                new Chat { Id = 46, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Yetrome1992:Yeah, I just finished this really cool science fiction novel called The Three-Body Problem. It's about this group of scientists who discover that aliens are planning to invade Earth.", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 1, 10, 50, 15)) },
                //indess(20) donew1987(15)
                new Chat { Id = 47, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Indess:Same here, just trying to stay busy with work and my hobbies. Speaking of hobbies, have you been playing any new games recently?", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 11, 10, 50, 15)) },
                //upoinfor(13) kntrl552(6)
                new Chat { Id = 48, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "kntrl552:Sure, that sounds like a great idea. When were you thinking?", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 11, 10, 50, 15)) },
                //scance2000(9) amine1980(11)
                new Chat { Id = 49, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Amine1980:Sure, what's up?", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(8, 13, 11, 10, 50, 15)) },
                //proothe(18) vertegro(3)
                new Chat { Id = 50, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Vertegro:Yeah, that sounds like a great idea. When were you thinking?", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(2, 15, 19, 10, 50, 15)) },
                //vlad1or(1) kntrl552(6)
                new Chat { Id = 51, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "vlad1or:Same here, I think I'll just be relaxing at home. Maybe I'll finally finish that book I've been reading.", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(16, 7, 5, 10, 50, 15)) },
                //vertegro(3) havaily(12)
                new Chat { Id = 52, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Vertegro:Sounds delicious! I'll have to make a reservation soon.", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(12, 10, 55, 10, 50, 15)) },
                //leared(7) yetrome1992(17)
                new Chat { Id = 53, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Yetrome1992:Thanks for the advice, I really appreciate it!", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(16, 2, 39, 10, 50, 15)) },
                //scance2000(9) donew1987(15)
                new Chat { Id = 54, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Scance2000:That would be great! How about we plan to go next Friday?", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(11, 9, 13, 10, 50, 15)) },
                //andow1994(14) lifare(19)
                new Chat { Id = 55, ChatInfo = "", ChatName = "",  ChatImage = null, MembersCount = 2, ShortMessage = "Lifeare:That would be awesome, let's plan to go next weekend if the weather is good!", AuthorId = null, Type = "Private", PublishTime = DateTime.Now.Subtract(new TimeSpan(17, 2, 12, 10, 50, 15)) }
                );
            //messages
            modelBuilder.Entity<Message>().HasData(
                new Message { Id = 1, UserId =2,   DeliveryStatus=true, Text = "Hello!", SendTime = DateTime.Now.Subtract(new TimeSpan(24, 4, 15, 9,40,15)) },
                new Message { Id = 2, UserId =2,  Text = "DONT IGNORE ME!!!!!", SendTime = DateTime.Now.Subtract(new TimeSpan(24, 4, 14, 9, 39, 0)) },
                new Message { Id = 3, UserId =3,   Text = "Wassupp!", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 4, 17, 15, 2, 15)) },
                new Message { Id = 4, UserId =5,  Text = "yo, bro, wassup", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 4, 13, 22, 10, 15)) },
                new Message { Id = 5, UserId =4,   Text = "This is start of this channel, welcome everyone!", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 4, 10, 9, 40, 15)) },
                new Message { Id = 6, UserId = 2,   Text = "He is ignoring me, its superannoying!!!!", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 4, 10, 9, 40, 15)) },
                new Message { Id = 7, UserId = 3,   Text = "He is sleeping, dumbass", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 4, 10, 9, 40, 15)) },
                //==============================================saved
                new Message { Id = 8, UserId = 1,   Text = "why olgerd is so angry...", SendTime = DateTime.Now.Subtract(new TimeSpan(13, 4, 5, 9, 40, 15)) },
                //==============================================channel posts
                //techtrends
                new Message { Id = 9, UserId = 14,   Text = "The Future of Wearable Technology: What to Expect in 2023\" - In this post, we'll explore the latest trends and advancements in wearable technology, from smartwatches to augmented reality glasses, and how they are shaping the way we live our lives.", SendTime = DateTime.Now.Subtract(new TimeSpan(22, 4, 11, 10, 50, 15)) },
                new Message { Id = 10, UserId = 14,   Text = "The Rise of Artificial Intelligence in Healthcare: How AI is Revolutionizing the Industry\" - From diagnosing diseases to developing new treatments, artificial intelligence is changing the face of healthcare. In this post, we'll explore the latest developments in AI technology and how they are being applied in the medical field.", SendTime = DateTime.Now.Subtract(new TimeSpan(18, 4, 11, 10, 50, 15)) },
                //fitlife
                new Message { Id = 11, UserId = 10,   Text = "10 Simple Habits to Boost Your Physical and Mental Health\" - Living a healthy lifestyle doesn't have to be complicated. In this post, we'll share 10 easy-to-implement habits that can help improve your overall well-being, from getting enough sleep to staying hydrated.", SendTime = DateTime.Now.Subtract(new TimeSpan(19, 6,15, 10, 50, 15)) },
                new Message { Id = 12, UserId = 10,   Text = "The Benefits of Yoga: Why You Should Incorporate This Practice Into Your Life\" - Yoga is more than just a physical exercise. In this post, we'll dive into the many benefits of yoga, from reducing stress and anxiety to improving flexibility and balance.", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 7, 25, 10, 50, 15)) },
                //motivationalquotes
                new Message { Id = 13, UserId = 19,   Text = "Finding Inspiration in Everyday Life: How to Stay Motivated When You're Feeling Stuck\" - We all have those moments when we feel unmotivated and uninspired. In this post, we'll share tips and tricks for finding inspiration in the world around you, from listening to podcasts to going for a walk in nature.", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 5, 13, 10, 50, 15)) },
                new Message { Id = 14, UserId = 19,   Text = "The Power of Positive Thinking: How Your Mindset Can Change Your Life\" - Your thoughts have a powerful impact on your life. In this post, we'll explore the concept of positive thinking and how it can help you achieve your goals and live a happier life.", SendTime = DateTime.Now.Subtract(new TimeSpan(4, 15, 21, 10, 50, 15)) },
                //wanderlusttravel
                new Message { Id = 15, UserId = 15,   Text = "Off-the-Beaten-Path Destinations: Exploring Hidden Gems Around the World\" - If you're looking for a unique travel experience, consider venturing off the beaten path. In this post, we'll share some of our favorite lesser-known destinations, from secluded beaches to remote mountain towns.", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 8, 11, 10, 50, 15)) },
                new Message { Id = 16, UserId = 15,   Text = "Sustainable Travel: How to Reduce Your Environmental Impact While Exploring the World\" - Traveling can have a significant impact on the environment. In this post, we'll share tips for traveling sustainably, from packing eco-friendly products to supporting local businesses.", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 2, 14, 10, 50, 15)) },
                //hollywoodbuzz
                new Message { Id = 17, UserId = 20,   Text = "The Most Anticipated Movies and TV Shows of 2023\" - From superhero blockbusters to gripping dramas, there's a lot to look forward to in the world of entertainment in 2023. In this post, we'll highlight some of the most anticipated movies and TV shows coming out this year.", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 11, 3, 10, 50, 15)) },
                new Message { Id = 18, UserId = 20,   Text = "Celebrity Style: Get Inspired by the Latest Fashion Trends From Your Favorite Stars\" - Whether you're a fashionista or just looking for some style inspiration, celebrity fashion can be a great source of ideas. In this post, we'll share some of the latest fashion trends from the red carpet and beyond.", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 21, 10, 50, 15)) },
                //==============================================group conversations
                //geek squad
                new Message { Id = 19, UserId = 1,   Text = "Hi everyone, has anyone played the new game Cyberpunk 2077 yet?", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 5, 15, 10, 50, 15)) },
                new Message { Id = 20, UserId = 6,   Text = "Yes, I have. It's a great game, but the bugs and glitches are a bit frustrating.", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 5, 12, 10, 50, 15)) },
                new Message { Id = 21, UserId = 5,   Text = "I haven't tried it yet, but I heard mixed reviews. What do you think of it, Vertegro?", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 5, 11, 10, 50, 15)) },
                new Message { Id = 22, UserId = 3,   Text = "I think it's a great game with a lot of potential. The bugs and glitches can be frustrating, but I'm sure they'll get fixed with time.", SendTime = DateTime.Now.Subtract(new TimeSpan(10, 5, 5, 10, 50, 15)) },
                //music mania
                new Message { Id = 23, UserId = 9,   Text = "What's everyone's favorite music genre?", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 11, 3, 10, 50, 15)) },
                new Message { Id = 24, UserId = 11,   Text = "I like Hip-hop and R&B.", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 11, 1, 10, 50, 15)) },
                new Message { Id = 25, UserId = 13,   Text = "I'm a fan of electronic music.", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 10, 55, 10, 50, 15)) },
                new Message { Id = 26, UserId = 14,   Text = "I love classic rock.", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 10, 54, 10, 50, 15)) },
                new Message { Id = 27, UserId = 16,   Text = "I'm into Indie and Alternative.", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 10, 43, 10, 50, 15)) },
                new Message { Id = 28, UserId = 17,   Text = "I'm a metalhead, I love Heavy Metal!", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 10, 37, 10, 50, 15)) },
                new Message { Id = 29, UserId = 19,   Text = "I'm a fan of Jazz and Blues.", SendTime = DateTime.Now.Subtract(new TimeSpan(25, 10, 26, 10, 50, 15)) },
                //2
                new Message { Id = 30, UserId = 15,   Text = "Hey guys, have you listened to the new album by The Weeknd? What do you think of it?", SendTime = DateTime.Now.Subtract(new TimeSpan(19, 7, 35, 10, 50, 15)) },
                new Message { Id = 31, UserId = 8,   Text = "Yes, I have, and I think it's pretty good. But it's not as good as his previous album.", SendTime = DateTime.Now.Subtract(new TimeSpan(19, 7, 30, 10, 50, 15)) },
                new Message { Id = 32, UserId = 7,   Text = "I haven't listened to it yet, but I'm planning to check it out soon.", SendTime = DateTime.Now.Subtract(new TimeSpan(19, 7, 27, 10, 50, 15)) },
                //book club
                //1
                new Message { Id = 33, UserId = 5,   Text = "Hey guys, what books are you reading right now?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 38, 10, 50, 15)) },
                new Message { Id = 34, UserId = 3,   Text = "I'm currently reading \"To Kill a Mockingbird\" by Harper Lee.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 27, 10, 50, 15)) },
                new Message { Id = 35, UserId = 7,   Text = "I just finished reading \"1984\" by George Orwell.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 25, 10, 50, 15)) },
                new Message { Id = 36, UserId = 9,   Text = "I'm reading \"The Great Gatsby\" by F. Scott Fitzgerald.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 23, 10, 50, 15)) },
                new Message { Id = 37, UserId = 20,   Text = "I'm reading \"The Catcher in the Rye\" by J.D. Salinger.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 15, 10, 50, 15)) },
                //2
                new Message { Id = 38, UserId = 2,   Text = "I'm looking for a good mystery novel to read. Any recommendations?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 12, 44, 10, 50, 15)) },
                new Message { Id = 39, UserId = 8,   Text = "You should check out \"Gone Girl\" by Gillian Flynn. It's a great page-turner.", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 12, 38, 10, 50, 15)) },
                new Message { Id = 40, UserId = 9,   Text = "I recently read \"The Girl on the Train\" by Paula Hawkins, and I thought it was a good mystery novel.", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 12, 29, 10, 50, 15)) },
                //film fanatics
                //1
                new Message { Id = 41, UserId = 3,   Text = "Hey guys, have you watched the new Marvel movie \"Shang-Chi\" yet?", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 7, 11, 10, 50, 15)) },
                new Message { Id = 42, UserId = 2,   Text = "Yes, I have, and I thought it was a great movie.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 7, 10, 10, 50, 15)) },
                new Message { Id = 43, UserId = 6,   Text = "I haven't seen it yet, but I'm planning to watch it this weekend.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 7, 7, 10, 50, 15)) },
                new Message { Id = 44, UserId = 9,   Text = "I watched it last week, and I loved it. The action scenes were amazing!", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 7, 1, 10, 50, 15)) },
                //2
                new Message { Id = 45, UserId = 5,   Text = "What's everyone's favorite movie of all time?", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 2, 25, 10, 50, 15)) },
                new Message { Id = 46, UserId = 3,   Text = "hat's a tough question. I have so many favorite movies. But if I had to choose one, it would be \"The Shawshank Redemption.\"", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 2, 23, 10, 50, 15)) },
                new Message { Id = 47, UserId = 6,   Text = "I love \"The Godfather.\" It's a classic.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 2, 19, 10, 50, 15)) },
                new Message { Id = 48, UserId = 9,   Text = "My favorite movie is \"Pulp Fiction\" by Quentin Tarantino.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 2, 4, 10, 50, 15)) },
                //sports talk
                //1 
                new Message { Id = 49, UserId = 11,   Text = "Hey guys, did you watch the latest UFC event?", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 11, 4, 10, 50, 15)) },
                new Message { Id = 50, UserId = 13,   Text = "Yes, I did. It was a great event, and the fights were really exciting.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 11, 2, 10, 50, 15)) },
                new Message { Id = 51, UserId = 7,   Text = "I'm not really into MMA, but I heard it was a good event.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 10, 57, 10, 50, 15)) },
                new Message { Id = 52, UserId = 8,   Text = "I didn't watch it, but I heard that one of the fighters got injured during the fight, that's too bad.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 10, 51, 10, 50, 15)) },
                //2
                new Message { Id = 53, UserId = 15,   Text = "What's everyone's favorite sports team?", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 4, 14, 10, 50, 15)) },
                new Message { Id = 54, UserId = 3,   Text = "I'm a big fan of the Los Angeles Lakers.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 4, 11, 10, 50, 15)) },
                new Message { Id = 55, UserId = 6,   Text = "I support the New England Patriots in the NFL.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 4, 7, 10, 50, 15)) },
                new Message { Id = 56, UserId = 9,   Text = "My favorite sports team is the New York Yankees in baseball.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 4, 3, 10, 50, 15)) },
                new Message { Id = 57, UserId = 13,   Text = "I'm a big fan of Barcelona FC in soccer.", SendTime = DateTime.Now.Subtract(new TimeSpan(3, 4, 1, 10, 50, 15)) },
                //foodies unite
                //1
                new Message { Id = 58, UserId = 16,   Text = "Hey guys, have you tried the new restaurant that just opened downtown?", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 9, 29, 10, 50, 15)) },
                new Message { Id = 59, UserId = 9,   Text = "No, I haven't. What kind of cuisine do they serve?", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 9, 14, 10, 50, 15)) },
                new Message { Id = 60, UserId = 16,   Text = "It's a Mexican restaurant, and the food is amazing.", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 9, 11, 10, 50, 15)) },
                new Message { Id = 61, UserId = 5,   Text = "I love Mexican food. I'll have to check it out.", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 9, 5, 10, 50, 15)) },
                //2
                new Message { Id = 62, UserId = 9,   Text = "What's everyone's favorite cuisine?", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 11, 37, 10, 50, 15)) },
                new Message { Id = 63, UserId = 2,   Text = "I love Italian food. Pasta is my weakness.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 11, 34, 10, 50, 15)) },
                new Message { Id = 64, UserId = 13,   Text = "I'm a big fan of Thai food. The flavors are so bold and spicy.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 11, 32, 10, 50, 15)) },
                //wanderlust
                //1
                new Message { Id = 65, UserId = 6,   Text = "Hey guys, where's the best place you've ever traveled to?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 3, 42, 10, 50, 15)) },
                new Message { Id = 66, UserId = 8,   Text = "I went to Japan last year, and it was amazing. The culture is so different from what I'm used to.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 3, 35, 10, 50, 15)) },
                new Message { Id = 67, UserId = 7,   Text = "I traveled to Spain a few years ago, and I fell in love with the country. The food, the architecture, and the people were all amazing.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 3, 31, 10, 50, 15)) },
                new Message { Id = 68, UserId = 13,   Text = "I went on a backpacking trip to South America a few years ago, and it was a life-changing experience.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 3, 27, 10, 50, 15)) },
                //2
                new Message { Id = 69, UserId = 9,   Text = "What's everyone's next travel destination?", SendTime = DateTime.Now.Subtract(new TimeSpan(4, 6, 27, 10, 50, 15)) },
                new Message { Id = 70, UserId = 3,   Text = "I'm planning a trip to Iceland to see the Northern Lights.", SendTime = DateTime.Now.Subtract(new TimeSpan(4, 6, 27, 10, 50, 15)) },
                new Message { Id = 71, UserId = 5,   Text = "I'm thinking of going to Thailand next year.", SendTime = DateTime.Now.Subtract(new TimeSpan(4, 6, 27, 10, 50, 15)) },
                new Message { Id = 72, UserId = 6,   Text = "I want to visit Machu Picchu in Peru.", SendTime = DateTime.Now.Subtract(new TimeSpan(4, 6, 27, 10, 50, 15)) },
                //furry friends
                //1
                new Message { Id = 73, UserId = 14,   Text = "Hey guys, do you have any pets?", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 4, 32, 10, 50, 15)) },
                new Message { Id = 74, UserId = 2,   Text = "I have a cat named Luna.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 4, 24, 10, 50, 15)) },
                new Message { Id = 75, UserId = 6,   Text = "I have a dog named Max.", SendTime = DateTime.Now.Subtract(new TimeSpan(15, 4, 11, 10, 50, 15)) },
                new Message { Id = 76, UserId = 16,   Text = "I have two rabbits named Thumper and Snowball.", SendTime = DateTime.Now.Subtract(new TimeSpan(15,2, 32, 10, 50, 15)) },
                //2
                new Message { Id = 77, UserId = 6,   Text = "What's everyone's favorite animal?", SendTime = DateTime.Now.Subtract(new TimeSpan(9, 9, 57, 10, 50, 15)) },
                new Message { Id = 78, UserId = 2,   Text = "I love cats. They're so independent and cute.", SendTime = DateTime.Now.Subtract(new TimeSpan(9, 9, 51, 10, 50, 15)) },
                new Message { Id = 79, UserId = 14,   Text = "I'm a dog person. I love how loyal and loving they are.", SendTime = DateTime.Now.Subtract(new TimeSpan(9, 9, 24, 10, 50, 15)) },
                new Message { Id = 80, UserId = 16,   Text = "I'm a big fan of rabbits. They're so fluffy and adorable.", SendTime = DateTime.Now.Subtract(new TimeSpan(9, 9, 19, 10, 50, 15)) },
                //art lovers
                //1
                new Message { Id = 81, UserId = 18,   Text = "Hey guys, have you been to the new art exhibit at the museum?", SendTime = DateTime.Now.Subtract(new TimeSpan(18, 4, 7, 10, 50, 15)) },
                new Message { Id = 82, UserId = 6,   Text = "No, I haven't. What kind of art is it?", SendTime = DateTime.Now.Subtract(new TimeSpan(18, 4, 3, 10, 50, 15)) },
                new Message { Id = 83, UserId = 18,   Text = "It's a contemporary art exhibit with some really interesting pieces.", SendTime = DateTime.Now.Subtract(new TimeSpan(18, 4, 2, 45, 50, 15)) },
                new Message { Id = 84, UserId = 3,   Text = "I love contemporary art. I'll have to check it out.", SendTime = DateTime.Now.Subtract(new TimeSpan(18, 4, 2, 10, 50, 15)) },
                //2
                new Message { Id = 85, UserId = 6,   Text = "What's everyone's favorite art style?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 19, 10, 50, 15)) },
                new Message { Id = 86, UserId = 3,   Text = "I love impressionism. The use of light and color is so beautiful.", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 15, 10, 50, 15)) },
                new Message { Id = 87, UserId = 16,   Text = "I'm a big fan of abstract art. I love how it can be interpreted in so many different ways.", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 14, 10, 50, 15)) },
                //fitness fanatics
                new Message { Id = 88, UserId = 2,   Text = "Hey guys, what's your favorite way to work out?", SendTime = DateTime.Now.Subtract(new TimeSpan(6, 7, 35, 10, 50, 15)) },
                new Message { Id = 89, UserId = 6,   Text = "I like to go for a run outside. It's a great way to clear my mind and get some fresh air.", SendTime = DateTime.Now.Subtract(new TimeSpan(6, 7, 31, 10, 50, 15)) },
                new Message { Id = 90, UserId = 3,   Text = "I prefer to lift weights at the gym. It's a great way to build strength and muscle.", SendTime = DateTime.Now.Subtract(new TimeSpan(6, 7, 22, 10, 50, 15)) },
                new Message { Id = 91, UserId = 7,   Text = "I like to do yoga. It's a great way to improve flexibility and relieve stress.", SendTime = DateTime.Now.Subtract(new TimeSpan(6, 7, 11, 10, 50, 15)) },
                //==============================================private conversations
                //birear(16) upoinfor(13)
                new Message { Id = 92, UserId = 16,   Text = "Hey Upoinfor, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 5, 11, 10, 50, 15)) },
                new Message { Id = 93, UserId = 13,   Text = "Hey Birear, I'm doing alright. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 5, 10, 10, 50, 15)) },
                new Message { Id = 94, UserId = 16,   Text = "Can't complain. Just busy with work as usual. What brings you here today?", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 5, 6, 10, 50, 15)) },
                new Message { Id = 95, UserId = 13,   Text = "Not much, just looking to chat with some people. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 5, 5, 10, 50, 15)) },
                new Message { Id = 96, UserId = 16,   Text = "Same here. Do you have any fun plans for the weekend?", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 5, 41, 10, 50, 15)) },
                new Message { Id = 97, UserId = 13,   Text = "Not really, just planning to catch up on some reading. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 5, 2, 10, 50, 15)) },
                new Message { Id = 98, UserId = 16,   Text = "I might go for a hike if the weather is nice. It's been a while since I've been out in nature.", SendTime = DateTime.Now.Subtract(new TimeSpan(21, 4, 58, 10, 50, 15)) },
                //vertegro(3) scance2000(9)
                new Message { Id = 99, UserId = 3,   Text = "Hey Scance2000, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 21, 10, 50, 15)) },
                new Message { Id = 100, UserId = 9,   Text = "Hey Vertegro, I'm doing pretty well. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 15, 10, 50, 15)) },
                new Message { Id = 101, UserId = 3,   Text = "Can't complain. Just trying to stay busy with work. What brings you here today?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 14, 43, 50, 15)) },
                new Message { Id = 102, UserId = 9,   Text = "Just looking for some good conversation. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 14, 4, 50, 15)) },
                new Message { Id = 103, UserId = 3,   Text = "Same here. What are some of your hobbies and interests?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 11, 10, 50, 15)) },
                new Message { Id = 104, UserId = 9,   Text = "I'm really into photography and travel. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 8, 10, 50, 15)) },
                new Message { Id = 105, UserId = 3,   Text = "I love playing guitar and hiking in the mountains. Have you traveled anywhere interesting lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 5, 10, 50, 15)) },
                new Message { Id = 106, UserId = 9,   Text = "Actually, I just got back from a trip to Japan. It was amazing.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 6, 2, 10, 50, 15)) },
                //havaily(12) donew1987(15)
                new Message { Id = 107, UserId = 12,   Text = "Hey Donew1987, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 27, 10, 50, 15)) },
                new Message { Id = 108, UserId = 15,   Text = "Hey Havaily, I'm doing pretty well. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 24, 10, 50, 15)) },
                new Message { Id = 109, UserId = 12,   Text = "Can't complain. Just trying to stay busy with work. What brings you here today?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 22, 10, 50, 15)) },
                new Message { Id = 110, UserId = 15,   Text = "Just looking to chat with some new people. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 21, 10, 50, 15)) },
                new Message { Id = 111, UserId = 12,   Text = "Same here. Do you have any fun plans for the weekend?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 15, 10, 50, 15)) },
                new Message { Id = 112, UserId = 15,   Text = "Not really, just planning to catch up on some movies. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 11, 10, 50, 15)) },
                new Message { Id = 113, UserId = 12,   Text = "I might go out for dinner with some friends. Have you seen any good movies lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 5, 10, 50, 15)) },
                new Message { Id = 114, UserId = 15,   Text = "Yeah, I just watched the new Spiderman movie. It was pretty good.", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 3, 3, 10, 50, 15)) },
                //jackKcaj(5) indess(20)
                new Message { Id = 115, UserId = 5,   Text = "Hey Indess, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 28, 10, 50, 15)) },
                new Message { Id = 116, UserId = 20,   Text = "Hey jackKcaj, I'm doing pretty well. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 25, 10, 50, 15)) },
                new Message { Id = 117, UserId = 5,   Text = "Can't complain. Just trying to stay busy with work. What brings you here today?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 23, 10, 50, 15)) },
                new Message { Id = 118, UserId = 20,   Text = "Just looking to chat with some new people. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 21, 10, 50, 15)) },
                new Message { Id = 119, UserId = 5,   Text = "Same here. What are some of your hobbies and interests?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 20, 10, 50, 15)) },
                new Message { Id = 120, UserId = 20,   Text = "I love playing video games and reading books. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 15, 10, 50, 15)) },
                new Message { Id = 121, UserId = 5,   Text = "I'm really into fitness and music. What kind of video games do you like to play?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 13, 10, 50, 15)) },
                new Message { Id = 122, UserId = 20,   Text = "Mostly RPGs and strategy games. Have you played any good ones lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 12, 10, 50, 15)) },
                new Message { Id = 123, UserId = 5,   Text = "Yeah, I've been playing a lot of Apex Legends. It's a really fun game.", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 14, 5, 10, 50, 15)) },
                //leared(7) whictime(8)
                new Message { Id = 124, UserId = 7,   Text = "Hi Whictime, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 3, 21, 10, 50, 15)) },
                new Message { Id = 125, UserId = 8,   Text = "Hey Leared, I'm doing pretty well, thanks for asking. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 2, 15, 10, 50, 15)) },
                new Message { Id = 126, UserId = 7,   Text = "I'm good too, thanks. So, what brings you here today?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 2, 11, 10, 50, 15)) },
                new Message { Id = 127, UserId = 8,   Text = "Not much, just wanted to catch up with some old friends. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 2, 10, 10, 50, 15)) },
                new Message { Id = 128, UserId = 7,   Text = "Same here, it's been a while since we've talked. So, what have you been up to lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 2, 5, 10, 50, 15)) },
                new Message { Id = 129, UserId = 8,   Text = "Oh, not much, just the usual work and family stuff. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 2, 4, 10, 50, 15)) },
                new Message { Id = 130, UserId = 7,   Text = "Same here, just trying to keep busy with work and my hobbies. Speaking of hobbies, have you been playing any new games recently?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 1, 58, 10, 50, 15)) },
                new Message { Id = 131, UserId = 8,   Text = "Actually, I have been playing this new game called Valheim. It's pretty cool, have you heard of it?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 1, 55, 10, 50, 15)) },
                new Message { Id = 132, UserId = 7,   Text = "No, I haven't. What's it about?", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 1, 52, 10, 50, 15)) },
                new Message { Id = 133, UserId = 8,   Text = "It's a survival game set in a Viking-themed world. You start with nothing and have to build your way up. It's pretty challenging but also really fun.", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 1, 47, 10, 50, 15)) },
                new Message { Id = 134, UserId = 7,   Text = "That sounds interesting, I might have to check it out sometime. Thanks for the recommendation!", SendTime = DateTime.Now.Subtract(new TimeSpan(23, 1, 42, 10, 50, 15)) },
                //proothe(18) yetrome1992(17)
                new Message { Id = 135, UserId = 18,   Text = "Hey Yetrome1992, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 28, 10, 50, 15)) },
                new Message { Id = 136, UserId = 17,   Text = "Not bad, thanks. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 21, 10, 50, 15)) },
                new Message { Id = 137, UserId = 18,   Text = "I'm doing pretty well too. So, what have you been up to lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 19, 10, 50, 15)) },
                new Message { Id = 138, UserId = 17,   Text = "Just the usual work stuff, you know how it is. What about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 15, 10, 50, 15)) },
                new Message { Id = 139, UserId = 18,   Text = "Same here, just trying to stay busy with work and my hobbies. Speaking of hobbies, have you been working on anything cool recently?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 11, 10, 50, 15)) },
                new Message { Id = 140, UserId = 17,   Text = "Yeah, actually, I've been getting into woodworking lately. I just made this really cool coffee table for my living room.", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 8, 10, 50, 15)) },
                new Message { Id = 141, UserId = 18,   Text = "That's awesome! I've always wanted to get into woodworking, but I've never had the time to learn.", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 7, 10, 50, 15)) },
                new Message { Id = 142, UserId = 17,   Text = "It's definitely a lot of work, but it's also really rewarding. You should give it a try sometime!", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 6, 10, 50, 15)) },
                new Message { Id = 143, UserId = 18,   Text = "Maybe I will, thanks for the inspiration! Speaking of inspiration, have you read any good books lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 5, 10, 50, 15)) },
                new Message { Id = 144, UserId = 17,   Text = "Yeah, I just finished this really cool science fiction novel called The Three-Body Problem. It's about this group of scientists who discover that aliens are planning to invade Earth.", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 3, 10, 50, 15)) },
                new Message { Id = 145, UserId = 18,   Text = "Wow, that sounds intense. I might have to check it out. Thanks for the recommendation!", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 7, 1, 10, 50, 15)) },
                //indess(20) donew1987(15)
                new Message { Id = 146, UserId = 20,   Text = "Hey Donew1987, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 53, 10, 50, 15)) },
                new Message { Id = 147, UserId = 15,   Text = "Hey Indess, I'm doing pretty well, thanks for asking. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 45, 10, 50, 15)) },
                new Message { Id = 148, UserId = 20,   Text = "I'm good too, thanks. So, what brings you here today?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 43, 10, 50, 15)) },
                new Message { Id = 149, UserId = 15,   Text = "Not much, just wanted to catch up with some old friends. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 42, 10, 50, 15)) },
                new Message { Id = 150, UserId = 20,   Text = "Same here, it's been a while since we've talked. So, what have you been up to lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 37, 10, 50, 15)) },
                new Message { Id = 151, UserId = 15,   Text = "Just the usual work stuff, you know how it is. What about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 28, 10, 50, 15)) },
                new Message { Id = 152, UserId = 20,   Text = "Same here, just trying to stay busy with work and my hobbies. Speaking of hobbies, have you been playing any new games recently?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 25, 10, 50, 15)) },
                new Message { Id = 153, UserId = 15,   Text = "Yeah, I just started playing this new game called Monster Hunter Rise. It's really fun, you should check it out!", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15, 22, 10, 50, 15)) },
                new Message { Id = 154, UserId = 20,   Text = "Oh, I've heard of that one.", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 15,11, 10, 50, 15)) },
                //havaily(12) donew1987(15)
                new Message { Id = 155, UserId = 12,   Text = "Hey, how are you doing?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 11, 35, 10, 50, 15)) },
                new Message { Id = 156, UserId = 15,   Text = "I'm good, thanks for asking. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 11, 33, 10, 50, 15)) },
                new Message { Id = 157, UserId = 12,   Text = "I'm doing alright. Just wanted to catch up with you.", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 11, 31, 10, 50, 15)) },
                new Message { Id = 158, UserId = 15,   Text = "Sounds good. What have you been up to lately?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 11, 28, 10, 50, 15)) },
                new Message { Id = 159, UserId = 12,   Text = "Not much, just working and spending time with my family. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(5, 11, 11, 10, 50, 15)) },
                //upoinfor(13) kntrl552(6)
                new Message { Id = 160, UserId = 13,   Text = "Hi there, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 25, 10, 50, 15)) },
                new Message { Id = 161, UserId = 6,   Text = "Hey! I'm doing pretty well, thanks. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 24, 10, 50, 15)) },
                new Message { Id = 162, UserId = 13,   Text = " I'm doing okay. I was just wondering if you wanted to grab a drink sometime this week.", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 21, 10, 50, 15)) },
                new Message { Id = 163, UserId = 6,   Text = "Sure, that sounds like a great idea. When were you thinking?", SendTime = DateTime.Now.Subtract(new TimeSpan(14, 5, 11, 10, 50, 15)) },
                //scance2000(9) amine1980(11)
                new Message { Id = 164, UserId = 9,   Text = "Hey, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 13, 24, 10, 50, 15)) },
                new Message { Id = 165, UserId = 11,   Text = "Not too bad, thanks for asking. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 13, 21, 10, 50, 15)) },
                new Message { Id = 166, UserId = 9,   Text = "I'm doing alright. I was actually hoping to get your opinion on something.", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 13, 15, 10, 50, 15)) },
                new Message { Id = 167, UserId = 11,   Text = "Sure, what's up?", SendTime = DateTime.Now.Subtract(new TimeSpan(8, 13, 11, 10, 50, 15)) },
                //proothe(18) vertegro(3)
                new Message { Id = 168, UserId = 18,   Text = "Hey, how's it going?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 15, 27, 10, 50, 15)) },
                new Message { Id = 169, UserId = 3,   Text = "Hey there! I'm doing pretty well, thanks. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 15, 24, 10, 50, 15)) },
                new Message { Id = 170, UserId = 18,   Text = "I'm doing alright. I was just wondering if you wanted to grab lunch sometime this week.", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 15, 22, 10, 50, 15)) },
                new Message { Id = 171, UserId = 3,   Text = "Yeah, that sounds like a great idea. When were you thinking?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 15, 19, 10, 50, 15)) },
                //jackKcaj(5) indess(20)
                new Message { Id = 172, UserId = 5,   Text = "Hi, how are you doing?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 32, 10, 50, 15)) },
                new Message { Id = 173, UserId = 20,   Text = "I'm good, thanks for asking. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 28, 10, 50, 15)) },
                new Message { Id = 174, UserId = 5,   Text = "I'm doing alright. I was just wondering if you wanted to hang out sometime this weekend.", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 24, 10, 50, 15)) },
                new Message { Id = 175, UserId = 20,   Text = "Yeah, that sounds like a great idea. What were you thinking of doing?", SendTime = DateTime.Now.Subtract(new TimeSpan(2, 11, 21, 10, 50, 15)) },
                //vlad1or(1) kntrl552(6)
                new Message { Id = 176, UserId = 1,   Text = "Hey there, how are you doing today?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 7, 15, 10, 50, 15)) },
                new Message { Id = 177, UserId = 6,   Text = "I'm doing pretty good, thanks for asking! How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 7, 13, 10, 50, 15)) },
                new Message { Id = 178, UserId = 1,   Text = "Can't complain, just trying to get through the workday. What do you have planned for the weekend?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 7, 11, 10, 50, 15)) },
                new Message { Id = 179, UserId = 6,   Text = "Not too much, just planning to catch up on some sleep and maybe do some gaming. How about you?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 7, 9, 10, 50, 15)) },
                new Message { Id = 180, UserId = 1,   Text = "Same here, I think I'll just be relaxing at home. Maybe I'll finally finish that book I've been reading.", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 7, 5, 10, 50, 15)) },
                //vertegro(3) havaily(12)
                new Message { Id = 181, UserId = 3,   Text = "Hey Havaily, I saw your post about the new restaurant that just opened up. Have you tried it yet?", SendTime = DateTime.Now.Subtract(new TimeSpan(12, 11, 9, 10, 50, 15)) },
                new Message { Id = 182, UserId = 12,   Text = "Yes, I actually went there last weekend. The food was amazing!", SendTime = DateTime.Now.Subtract(new TimeSpan(12, 11, 5, 10, 50, 15)) },
                new Message { Id = 183, UserId = 3,   Text = "Oh wow, I definitely have to check it out then. What would you recommend ordering?", SendTime = DateTime.Now.Subtract(new TimeSpan(12, 11, 2, 10, 50, 15)) },
                new Message { Id = 184, UserId = 12,   Text = "Definitely try the lasagna, it was so good. And the tiramisu for dessert was also amazing.", SendTime = DateTime.Now.Subtract(new TimeSpan(12, 10, 58, 10, 50, 15)) },
                new Message { Id = 185, UserId = 3,   Text = "Sounds delicious! I'll have to make a reservation soon.", SendTime = DateTime.Now.Subtract(new TimeSpan(12, 10, 55, 10, 50, 15)) },
                //leared(7) yetrome1992(17)
                new Message { Id = 186, UserId = 7,   Text = "Hey Yetrome1992, do you have any advice for someone who's new to the gym?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 2, 55, 10, 50, 15)) },
                new Message { Id = 187, UserId = 17,   Text = "Sure, what do you need help with specifically?", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 2, 51, 10, 50, 15)) },
                new Message { Id = 188, UserId = 7,   Text = "I'm not really sure what exercises I should be doing, and I'm a bit intimidated by all the equipment.", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 2, 47, 10, 50, 15)) },
                new Message { Id = 189, UserId = 17,   Text = "I totally understand, it can be overwhelming at first. I would recommend starting with some basic exercises like squats, lunges, and bench press. And don't be afraid to ask someone for help if you're not sure how to use a machine.", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 2, 45, 10, 50, 15)) },
                new Message { Id = 190, UserId = 7,   Text = "Thanks for the advice, I really appreciate it!", SendTime = DateTime.Now.Subtract(new TimeSpan(16, 2, 39, 10, 50, 15)) },
                //scance2000(9) donew1987(15)
                new Message { Id = 191, UserId = 9,   Text = "Hey Donew1987, have you heard about the new movie that's coming out next week?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 9, 29, 10, 50, 15)) },
                new Message { Id = 192, UserId = 15,   Text = "No, I haven't. What's it called?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 9, 24, 10, 50, 15)) },
                new Message { Id = 193, UserId = 9,   Text = "It's called \"The Last Resort\", it's supposed to be a really intense thriller.", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 9, 21, 10, 50, 15)) },
                new Message { Id = 194, UserId = 15,   Text = "Sounds interesting! Do you want to go see it together?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 9, 16, 10, 50, 15)) },
                new Message { Id = 195, UserId = 9,   Text = "That would be great! How about we plan to go next Friday?", SendTime = DateTime.Now.Subtract(new TimeSpan(11, 9, 13, 10, 50, 15)) },
                //andow1994(14) lifare(19)
                new Message { Id = 196, UserId = 14,   Text = "Hey Lifeare, I noticed that you're also into photography. Do you have any favorite spots to take pictures around here?", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 2, 24, 10, 50, 15)) },
                new Message { Id = 197, UserId = 19,   Text = "Yes, I love taking pictures in nature. There's a really beautiful park on the outskirts of town that I like to go to. And there's also a lake nearby that's really scenic.", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 2, 19, 10, 50, 15)) },
                new Message { Id = 198, UserId = 14,  Text = "Those both sound like great spots. Do you want to plan a day to go take some pictures together?", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 2, 17, 10, 50, 15)) },
                new Message { Id = 199, UserId = 19, Text = "That would be awesome, let's plan to go next weekend if the weather is good!", SendTime = DateTime.Now.Subtract(new TimeSpan(17, 2, 12, 10, 50, 15)) }
                );
            modelBuilder.Entity<ChatMessage>().HasData(
                new ChatMessage { ChatId = 1, MessageId = 6 },
                new ChatMessage { ChatId = 1, MessageId = 7 },
                new ChatMessage { ChatId = 4, MessageId = 1 },
                new ChatMessage { ChatId = 4, MessageId = 2 },
                new ChatMessage { ChatId = 5, MessageId = 3 },
                new ChatMessage { ChatId = 5, MessageId = 4 },
                new ChatMessage { ChatId = 3, MessageId = 5 },
                //==============================================saved
                new ChatMessage { ChatId = 6, MessageId = 8 },
                //==============================================channel posts
                //techtrends
                new ChatMessage { ChatId = 36, MessageId = 9 },
                new ChatMessage { ChatId = 36, MessageId = 10 },
                //fitlife
                new ChatMessage { ChatId = 37, MessageId = 11 },
                new ChatMessage { ChatId = 37, MessageId = 12 },
                //motivationalquotes
                new ChatMessage { ChatId = 38, MessageId = 13 },
                new ChatMessage { ChatId = 38, MessageId = 14 },
                //wanderlusttravel
                new ChatMessage { ChatId = 39, MessageId = 15 },
                new ChatMessage { ChatId = 39, MessageId = 16 },
                //hollywoodbuzz
                new ChatMessage { ChatId = 40, MessageId = 17 },
                new ChatMessage { ChatId = 40, MessageId = 18 },
                //==============================================groups conversations
                //geek squad
                new ChatMessage { ChatId = 26, MessageId = 19 },
                new ChatMessage { ChatId = 26, MessageId = 20 },
                new ChatMessage { ChatId = 26, MessageId = 21 },
                new ChatMessage { ChatId = 26, MessageId = 22 },
                //music mania
                new ChatMessage { ChatId = 27, MessageId = 23 },
                new ChatMessage { ChatId = 27, MessageId = 24 },
                new ChatMessage { ChatId = 27, MessageId = 25 },
                new ChatMessage { ChatId = 27, MessageId = 26 },
                new ChatMessage { ChatId = 27, MessageId = 27 },
                new ChatMessage { ChatId = 27, MessageId = 28 },
                new ChatMessage { ChatId = 27, MessageId = 29 },
                new ChatMessage { ChatId = 27, MessageId = 30 },
                new ChatMessage { ChatId = 27, MessageId = 31 },
                new ChatMessage { ChatId = 27, MessageId = 32 },
                //book club
                new ChatMessage { ChatId = 28, MessageId = 33 },
                new ChatMessage { ChatId = 28, MessageId = 34 },
                new ChatMessage { ChatId = 28, MessageId = 35 },
                new ChatMessage { ChatId = 28, MessageId = 36 },
                new ChatMessage { ChatId = 28, MessageId = 37 },
                new ChatMessage { ChatId = 28, MessageId = 38 },
                new ChatMessage { ChatId = 28, MessageId = 39 },
                new ChatMessage { ChatId = 28, MessageId = 40 },
                //film fanatics
                new ChatMessage { ChatId = 29, MessageId = 41 },
                new ChatMessage { ChatId = 29, MessageId = 42 },
                new ChatMessage { ChatId = 29, MessageId = 43 },
                new ChatMessage { ChatId = 29, MessageId = 44 },
                new ChatMessage { ChatId = 29, MessageId = 45 },
                new ChatMessage { ChatId = 29, MessageId = 46 },
                new ChatMessage { ChatId = 29, MessageId = 47 },
                new ChatMessage { ChatId = 29, MessageId = 48 },
                //sports talk
                new ChatMessage { ChatId = 30, MessageId = 49 },
                new ChatMessage { ChatId = 30, MessageId = 50 },
                new ChatMessage { ChatId = 30, MessageId = 51 },
                new ChatMessage { ChatId = 30, MessageId = 52 },
                new ChatMessage { ChatId = 30, MessageId = 53 },
                new ChatMessage { ChatId = 30, MessageId = 54 },
                new ChatMessage { ChatId = 30, MessageId = 55 },
                new ChatMessage { ChatId = 30, MessageId = 56 },
                new ChatMessage { ChatId = 30, MessageId = 57 },
                //foodies unite
                new ChatMessage { ChatId = 31, MessageId = 58 },
                new ChatMessage { ChatId = 31, MessageId = 59 },
                new ChatMessage { ChatId = 31, MessageId = 60 },
                new ChatMessage { ChatId = 31, MessageId = 61 },
                new ChatMessage { ChatId = 31, MessageId = 62 },
                new ChatMessage { ChatId = 31, MessageId = 63 },
                new ChatMessage { ChatId = 31, MessageId = 64 },
                //wanderlust
                new ChatMessage { ChatId = 32, MessageId = 65 },
                new ChatMessage { ChatId = 32, MessageId = 66 },
                new ChatMessage { ChatId = 32, MessageId = 67 },
                new ChatMessage { ChatId = 32, MessageId = 68 },
                new ChatMessage { ChatId = 32, MessageId = 69 },
                new ChatMessage { ChatId = 32, MessageId = 70 },
                new ChatMessage { ChatId = 32, MessageId = 71 },
                new ChatMessage { ChatId = 32, MessageId = 72 },
                //furry friends
                new ChatMessage { ChatId = 33, MessageId = 73 },
                new ChatMessage { ChatId = 33, MessageId = 74 },
                new ChatMessage { ChatId = 33, MessageId = 75 },
                new ChatMessage { ChatId = 33, MessageId = 76 },
                new ChatMessage { ChatId = 33, MessageId = 77 },
                new ChatMessage { ChatId = 33, MessageId = 78 },
                new ChatMessage { ChatId = 33, MessageId = 79 },
                new ChatMessage { ChatId = 33, MessageId = 80 },
                //art lovers
                new ChatMessage { ChatId = 34, MessageId = 81 },
                new ChatMessage { ChatId = 34, MessageId = 82 },
                new ChatMessage { ChatId = 34, MessageId = 83 },
                new ChatMessage { ChatId = 34, MessageId = 84 },
                new ChatMessage { ChatId = 34, MessageId = 85 },
                new ChatMessage { ChatId = 34, MessageId = 86 },
                new ChatMessage { ChatId = 34, MessageId = 87 },
                //fitness fanatics
                new ChatMessage { ChatId = 35, MessageId = 88 },
                new ChatMessage { ChatId = 35, MessageId = 89 },
                new ChatMessage { ChatId = 35, MessageId = 90 },
                new ChatMessage { ChatId = 35, MessageId = 91 },
//==============================================private conversations
                //birear(16) upoinfor(13)
                new ChatMessage { ChatId = 41, MessageId = 92 },
                new ChatMessage { ChatId = 41, MessageId = 93 },
                new ChatMessage { ChatId = 41, MessageId = 94 },
                new ChatMessage { ChatId = 41, MessageId = 95 },
                new ChatMessage { ChatId = 41, MessageId = 96 },
                new ChatMessage { ChatId = 41, MessageId = 97 },
                new ChatMessage { ChatId = 41, MessageId = 98 },
                //vertegro(3) scance2000(9)
                new ChatMessage { ChatId = 42, MessageId = 99 },
                new ChatMessage { ChatId = 42, MessageId = 100 },
                new ChatMessage { ChatId = 42, MessageId = 101 },
                new ChatMessage { ChatId = 42, MessageId = 102 },
                new ChatMessage { ChatId = 42, MessageId = 103 },
                new ChatMessage { ChatId = 42, MessageId = 104 },
                new ChatMessage { ChatId = 42, MessageId = 105 },
                new ChatMessage { ChatId = 42, MessageId = 106 },
                //havaily(12) donew1987(15)
                new ChatMessage { ChatId = 43, MessageId = 107 },
                new ChatMessage { ChatId = 43, MessageId = 108 },
                new ChatMessage { ChatId = 43, MessageId = 109 },
                new ChatMessage { ChatId = 43, MessageId = 110 },
                new ChatMessage { ChatId = 43, MessageId = 111 },
                new ChatMessage { ChatId = 43, MessageId = 112 },
                new ChatMessage { ChatId = 43, MessageId = 113 },
                new ChatMessage { ChatId = 43, MessageId = 114 },
                //jackKcaj(5) indess(20)
                new ChatMessage { ChatId = 44, MessageId = 115 },
                new ChatMessage { ChatId = 44, MessageId = 116 },
                new ChatMessage { ChatId = 44, MessageId = 117 },
                new ChatMessage { ChatId = 44, MessageId = 118 },
                new ChatMessage { ChatId = 44, MessageId = 119 },
                new ChatMessage { ChatId = 44, MessageId = 120 },
                new ChatMessage { ChatId = 44, MessageId = 121 },
                new ChatMessage { ChatId = 44, MessageId = 122 },
                new ChatMessage { ChatId = 44, MessageId = 123 },
                //leared(7) whictime(8)
                new ChatMessage { ChatId = 45, MessageId = 124 },
                new ChatMessage { ChatId = 45, MessageId = 125 },
                new ChatMessage { ChatId = 45, MessageId = 126 },
                new ChatMessage { ChatId = 45, MessageId = 127 },
                new ChatMessage { ChatId = 45, MessageId = 128 },
                new ChatMessage { ChatId = 45, MessageId = 129 },
                new ChatMessage { ChatId = 45, MessageId = 130 },
                new ChatMessage { ChatId = 45, MessageId = 131 },
                new ChatMessage { ChatId = 45, MessageId = 132 },
                new ChatMessage { ChatId = 45, MessageId = 133 },
                new ChatMessage { ChatId = 45, MessageId = 134 },
                //proothe(18) yetrome1992(17)
                new ChatMessage { ChatId = 46, MessageId = 135 },
                new ChatMessage { ChatId = 46, MessageId = 136 },
                new ChatMessage { ChatId = 46, MessageId = 137 },
                new ChatMessage { ChatId = 46, MessageId = 138 },
                new ChatMessage { ChatId = 46, MessageId = 139 },
                new ChatMessage { ChatId = 46, MessageId = 140 },
                new ChatMessage { ChatId = 46, MessageId = 141 },
                new ChatMessage { ChatId = 46, MessageId = 142 },
                new ChatMessage { ChatId = 46, MessageId = 143 },
                new ChatMessage { ChatId = 46, MessageId = 144 },
                //indess(20) donew1987(15)
                new ChatMessage { ChatId = 47, MessageId = 146 },
                new ChatMessage { ChatId = 47, MessageId = 147 },
                new ChatMessage { ChatId = 47, MessageId = 148 },
                new ChatMessage { ChatId = 47, MessageId = 149 },
                new ChatMessage { ChatId = 47, MessageId = 150 },
                new ChatMessage { ChatId = 47, MessageId = 151 },
                new ChatMessage { ChatId = 47, MessageId = 152 },
                //havaily(12) donew1987(15)
                new ChatMessage { ChatId = 43, MessageId = 155 },
                new ChatMessage { ChatId = 43, MessageId = 156 },
                new ChatMessage { ChatId = 43, MessageId = 157 },
                new ChatMessage { ChatId = 43, MessageId = 158 },
                new ChatMessage { ChatId = 43, MessageId = 159 },
                //upoinfor(13) kntrl552(6)
                new ChatMessage { ChatId = 48, MessageId = 160 },
                new ChatMessage { ChatId = 48, MessageId = 161 },
                new ChatMessage { ChatId = 48, MessageId = 162 },
                new ChatMessage { ChatId = 48, MessageId = 163 },
                //scance2000(9) amine1980(11)
                new ChatMessage { ChatId = 49, MessageId = 164 },
                new ChatMessage { ChatId = 49, MessageId = 165 },
                new ChatMessage { ChatId = 49, MessageId = 166 },
                new ChatMessage { ChatId = 49, MessageId = 167 },
                //proothe(18) vertegro(3)
                new ChatMessage { ChatId = 50, MessageId = 168 },
                new ChatMessage { ChatId = 50, MessageId = 169 },
                new ChatMessage { ChatId = 50, MessageId = 170 },
                new ChatMessage { ChatId = 50, MessageId = 171 },
                //jackKcaj(5) indess(20)
                new ChatMessage { ChatId = 44, MessageId = 172 },
                new ChatMessage { ChatId = 44, MessageId = 173 },
                new ChatMessage { ChatId = 44, MessageId = 174 },
                new ChatMessage { ChatId = 44, MessageId = 175 },
                //vlad1or(1) kntrl552(6)
                new ChatMessage { ChatId = 51, MessageId = 176 },
                new ChatMessage { ChatId = 51, MessageId = 177 },
                new ChatMessage { ChatId = 51, MessageId = 178 },
                new ChatMessage { ChatId = 51, MessageId = 179 },
                new ChatMessage { ChatId = 51, MessageId = 180 },
                //vertegro(3) havaily(12)
                new ChatMessage { ChatId = 52, MessageId = 181 },
                new ChatMessage { ChatId = 52, MessageId = 182 },
                new ChatMessage { ChatId = 52, MessageId = 183 },
                new ChatMessage { ChatId = 52, MessageId = 184 },
                new ChatMessage { ChatId = 52, MessageId = 185 },
                //leared(7) yetrome1992(17)
                new ChatMessage { ChatId = 53, MessageId = 186 },
                new ChatMessage { ChatId = 53, MessageId = 187 },
                new ChatMessage { ChatId = 53, MessageId = 188 },
                new ChatMessage { ChatId = 53, MessageId = 189 },
                new ChatMessage { ChatId = 53, MessageId = 190 },
                //scance2000(9) donew1987(15)
                new ChatMessage { ChatId = 54, MessageId = 191 },
                new ChatMessage { ChatId = 54, MessageId = 192 },
                new ChatMessage { ChatId = 54, MessageId = 193 },
                new ChatMessage { ChatId = 54, MessageId = 194 },
                new ChatMessage { ChatId = 54, MessageId = 195 },
                //andow1994(14) lifare(19)
                new ChatMessage { ChatId = 55, MessageId = 196 },
                new ChatMessage { ChatId = 55, MessageId = 197 },
                new ChatMessage { ChatId = 55, MessageId = 198 },
                new ChatMessage { ChatId = 55, MessageId = 199 }
                );
            //userchats
            modelBuilder.Entity<UserChat>().HasData(
                new UserChat { ChatId=5, UserId = 3 },
                new UserChat { ChatId = 5, UserId = 5 },
                //==============================================saved messages chats
                new UserChat {ChatId = 6, UserId =  1},
                new UserChat { ChatId = 7, UserId = 2 },
                new UserChat { ChatId = 8, UserId =  3},
                new UserChat { ChatId = 9, UserId =  4},
                new UserChat { ChatId = 10, UserId = 5 },
                new UserChat { ChatId = 11, UserId = 6 },
                new UserChat { ChatId = 12, UserId = 7 },
                new UserChat { ChatId = 13, UserId = 8 },
                new UserChat { ChatId = 14, UserId = 9 },
                new UserChat { ChatId = 15, UserId = 10 },
                new UserChat { ChatId = 16, UserId = 11 },
                new UserChat { ChatId = 17, UserId = 12 },
                new UserChat { ChatId = 18, UserId = 13 },
                new UserChat { ChatId = 19, UserId = 14 },
                new UserChat { ChatId = 20, UserId = 15 },
                new UserChat { ChatId = 21, UserId = 16 },
                new UserChat { ChatId = 22, UserId = 17 },
                new UserChat { ChatId = 23, UserId = 18 },
                new UserChat { ChatId = 24, UserId = 19 },
                new UserChat { ChatId = 25, UserId = 20 },
                //==============================================user groups
                //first
                new UserChat { ChatId = 1, UserId = 2 },
                new UserChat { ChatId = 1, UserId = 3 },
                new UserChat { ChatId = 1, UserId = 4 },
                //geek squad
                new UserChat { ChatId = 26, UserId = 1 },
                new UserChat { ChatId = 26, UserId = 2 },
                new UserChat { ChatId = 26, UserId = 3 },
                new UserChat { ChatId = 26, UserId = 5 },
                new UserChat { ChatId = 26, UserId = 6 },
                //music mania
                new UserChat { ChatId = 27, UserId = 7 },
                new UserChat { ChatId = 27, UserId = 8 },
                new UserChat { ChatId = 27, UserId = 9 },
                new UserChat { ChatId = 27, UserId = 11 },
                new UserChat { ChatId = 27, UserId = 13 },
                new UserChat { ChatId = 27, UserId = 14 },
                new UserChat { ChatId = 27, UserId = 15 },
                new UserChat { ChatId = 27, UserId = 16 },
                new UserChat { ChatId = 27, UserId = 17 },
                new UserChat { ChatId = 27, UserId = 19 },
                //book club
                new UserChat { ChatId = 28, UserId = 1 },
                new UserChat { ChatId = 28, UserId = 2 },
                new UserChat { ChatId = 28, UserId = 3 },
                new UserChat { ChatId = 28, UserId = 5 },
                new UserChat { ChatId = 28, UserId = 7 },
                new UserChat { ChatId = 28, UserId = 8 },
                new UserChat { ChatId = 28, UserId = 9 },
                new UserChat { ChatId = 28, UserId = 20 },
                //film fanatics
                new UserChat { ChatId = 29, UserId = 1 },
                new UserChat { ChatId = 29, UserId = 2 },
                new UserChat { ChatId = 29, UserId = 3 },
                new UserChat { ChatId = 29, UserId = 5 },
                new UserChat { ChatId = 29, UserId = 6 },
                new UserChat { ChatId = 29, UserId = 9 },
                new UserChat { ChatId = 29, UserId = 13 },
                //sports talk
                new UserChat { ChatId = 30, UserId = 1 },
                new UserChat { ChatId = 30, UserId = 2 },
                new UserChat { ChatId = 30, UserId = 3 },
                new UserChat { ChatId = 30, UserId = 5 },
                new UserChat { ChatId = 30, UserId = 6 },
                new UserChat { ChatId = 30, UserId = 7 },
                new UserChat { ChatId = 30, UserId = 8 },
                new UserChat { ChatId = 30, UserId = 9 },
                new UserChat { ChatId = 30, UserId = 11 },
                new UserChat { ChatId = 30, UserId = 13 },
                new UserChat { ChatId = 30, UserId = 15 },
                new UserChat { ChatId = 30, UserId = 17 },
                //foodies unite
                new UserChat { ChatId = 31, UserId = 1 },
                new UserChat { ChatId = 31, UserId = 2 },
                new UserChat { ChatId = 31, UserId = 3 },
                new UserChat { ChatId = 31, UserId = 5 },
                new UserChat { ChatId = 31, UserId = 9 },
                new UserChat { ChatId = 31, UserId = 16 },
                //wanderlust
                new UserChat { ChatId = 32, UserId = 1 },
                new UserChat { ChatId = 32, UserId = 2 },
                new UserChat { ChatId = 32, UserId = 3 },
                new UserChat { ChatId = 32, UserId = 5 },
                new UserChat { ChatId = 32, UserId = 6 },
                new UserChat { ChatId = 32, UserId = 7 },
                new UserChat { ChatId = 32, UserId = 8 },
                new UserChat { ChatId = 32, UserId = 9 },
                new UserChat { ChatId = 32, UserId = 13 },
                //furry friends
                new UserChat { ChatId = 33, UserId = 2 },
                new UserChat { ChatId = 33, UserId = 6 },
                new UserChat { ChatId = 33, UserId = 14 },
                new UserChat { ChatId = 33, UserId = 16 },
                //art lovers
                new UserChat { ChatId = 34, UserId = 3 },
                new UserChat { ChatId = 34, UserId = 6 },
                new UserChat { ChatId = 34, UserId = 18 },
                //fitness fanatics
                new UserChat { ChatId = 35, UserId = 1 },
                new UserChat { ChatId = 35, UserId = 2 },
                new UserChat { ChatId = 35, UserId = 3 },
                new UserChat { ChatId = 35, UserId = 5 },
                new UserChat { ChatId = 35, UserId = 6 },
                new UserChat { ChatId = 35, UserId = 7 },
                new UserChat { ChatId = 35, UserId = 8 },
                new UserChat { ChatId = 35, UserId = 9 },
                new UserChat { ChatId = 35, UserId = 11 },
                new UserChat { ChatId = 35, UserId = 13 },
                new UserChat { ChatId = 35, UserId = 17 },
                //==============================================user channels
                //openai fun club
                new UserChat { ChatId=2, UserId=2},
                //programming news
                new UserChat { ChatId = 3, UserId = 4 },
                new UserChat { ChatId = 3, UserId = 1 },
                //techtrends
                new UserChat { ChatId = 36, UserId = 1 },
                new UserChat { ChatId = 36, UserId = 2 },
                new UserChat { ChatId = 36, UserId = 6 },
                new UserChat { ChatId = 36, UserId = 14 },
                //fitlife
                new UserChat { ChatId = 37, UserId = 7 },
                new UserChat { ChatId = 37, UserId = 8 },
                new UserChat { ChatId = 37, UserId = 9 },
                new UserChat { ChatId = 37, UserId = 10 },
                new UserChat { ChatId = 37, UserId = 11 },
                new UserChat { ChatId = 37, UserId = 12 },
                new UserChat { ChatId = 37, UserId = 13 },
                //motivationalquotes
                new UserChat { ChatId = 38, UserId = 2 },
                new UserChat { ChatId = 38, UserId = 5 },
                new UserChat { ChatId = 38, UserId = 11 },
                new UserChat { ChatId = 38, UserId = 17 },
                new UserChat { ChatId = 38, UserId = 19 },
                //wanderlusttravel
                new UserChat { ChatId = 39, UserId = 2 },
                new UserChat { ChatId = 39, UserId = 3 },
                new UserChat { ChatId = 39, UserId = 6 },
                new UserChat { ChatId = 39, UserId = 9 },
                new UserChat { ChatId = 39, UserId = 15 },
                new UserChat { ChatId = 39, UserId = 16 },
                new UserChat { ChatId = 39, UserId = 17 },
                new UserChat { ChatId = 39, UserId = 20 },
                new UserChat { ChatId = 39, UserId = 10 },
                //hollywoodbuzz
                new UserChat { ChatId = 40, UserId = 1 },
                new UserChat { ChatId = 40, UserId = 2 },
                new UserChat { ChatId = 40, UserId = 3 },
                new UserChat { ChatId = 40, UserId = 4 },
                new UserChat { ChatId = 40, UserId = 5 },
                new UserChat { ChatId = 40, UserId = 7 },
                new UserChat { ChatId = 40, UserId = 8 },
                new UserChat { ChatId = 40, UserId = 9 },
                new UserChat { ChatId = 40, UserId = 15 },
                new UserChat { ChatId = 40, UserId = 18 },
                new UserChat { ChatId = 40, UserId = 19 },
                new UserChat { ChatId = 40, UserId = 20 },
                //==============================================private chats
                //birear(16) upoinfor(13)
                new UserChat { ChatId = 41, UserId = 16 },
                new UserChat { ChatId = 41, UserId = 13 },
                //vertegro(3) scance2000(9)
                new UserChat { ChatId = 42, UserId = 3 },
                new UserChat { ChatId = 42, UserId = 9 },
                //havaily(12) donew1987(15)
                new UserChat { ChatId = 43, UserId = 12 },
                new UserChat { ChatId = 43, UserId = 15 },
                //jackKcaj(5) indess(20)
                new UserChat { ChatId = 44, UserId = 5 },
                new UserChat { ChatId = 44, UserId = 20 },
                //leared(7) whictime(8)
                new UserChat { ChatId = 45, UserId = 7 },
                new UserChat { ChatId = 45, UserId = 8 },
                //proothe(18) yetrome1992(17)
                new UserChat { ChatId = 46, UserId = 18 },
                new UserChat { ChatId = 46, UserId = 17 },
                //indess(20) donew1987(15)
                new UserChat { ChatId = 47, UserId = 20 },
                new UserChat { ChatId = 47, UserId = 15 },
                //upoinfor(13) kntrl552(6)
                new UserChat { ChatId = 48, UserId = 13 },
                new UserChat { ChatId = 48, UserId = 6 },
                //scance2000(9) amine1980(11)
                new UserChat { ChatId = 49, UserId = 9 },
                new UserChat { ChatId = 49, UserId = 11 },
                //proothe(18) vertegro(3)
                new UserChat { ChatId = 50, UserId = 18 },
                new UserChat { ChatId = 50, UserId = 3 },
                //vladior(1) kntrl552(6)
                new UserChat { ChatId = 51, UserId = 1 },
                new UserChat { ChatId = 51, UserId = 6 },
                //vertegro(3) havaily(12)
                new UserChat { ChatId = 52, UserId = 3 },
                new UserChat { ChatId = 52, UserId = 12 },
                //leared(7) yetrome1992(17)
                new UserChat { ChatId = 53, UserId = 7 },
                new UserChat { ChatId = 53, UserId = 17 },
                //scance2000(9) donew1987(15)
                new UserChat { ChatId = 54, UserId = 9 },
                new UserChat { ChatId = 54, UserId = 15 },
                //andow1994(14) lifare(19)
                new UserChat { ChatId = 55, UserId = 14 },
                new UserChat { ChatId = 55, UserId = 19 }
                );

            //bugReports
            modelBuilder.Entity<BugReport>().HasData(
                new BugReport {Id=1, BugDescription="stupid bug.", BugTitle="just trolling you, chill", Date=DateTime.UtcNow, UserName="olgerd17" }
                );
            //userContacts
            modelBuilder.Entity<UserContact>().HasData(
                new UserContact { Id = 1, NotificationStatus =true,  ContactId=1, UserId=2 },

                //birear(16) upoinfor(13)
                new UserContact { Id = 2, NotificationStatus = true, ContactId = 13, UserId = 16 },
                new UserContact { Id = 3, NotificationStatus = true, ContactId = 16, UserId = 13 },
                //vertegro(3) scance2000(9)
                new UserContact { Id = 4, NotificationStatus = true, ContactId = 3, UserId = 9 },
                new UserContact { Id = 5, NotificationStatus = true, ContactId = 9, UserId = 3 },
                //havaily(12) donew1987(15)
                new UserContact { Id = 6, NotificationStatus = true, ContactId = 15, UserId = 12 },
                new UserContact { Id = 7, NotificationStatus = true, ContactId = 12, UserId = 15 },
                //jackKcaj(5) indess(20)
                new UserContact { Id = 8, NotificationStatus = true, ContactId = 5, UserId = 20 },
                new UserContact { Id = 9, NotificationStatus = true, ContactId = 20, UserId = 5 },
                //leared(7) whictime(8)
                new UserContact { Id = 10, NotificationStatus = true, ContactId = 7, UserId = 8 },
                new UserContact { Id = 11, NotificationStatus = true, ContactId = 8, UserId = 7 },
                //proothe(18) yetrome1992(17)
                new UserContact { Id = 12, NotificationStatus = true, ContactId = 18, UserId = 17 },
                new UserContact { Id = 13, NotificationStatus = true, ContactId = 17, UserId = 18 },
                //indess(20) donew1987(15)
                new UserContact { Id = 14, NotificationStatus = true, ContactId = 15, UserId = 20 },
                new UserContact { Id = 15, NotificationStatus = true, ContactId = 20, UserId = 15 },
                //upoinfor(13) kntrl552(6)
                new UserContact { Id = 16, NotificationStatus = true, ContactId = 13, UserId = 6 },
                new UserContact { Id = 17, NotificationStatus = true, ContactId = 6, UserId = 13 },
                //scance2000(9) amine1980(11)
                new UserContact { Id = 18, NotificationStatus = true, ContactId = 9, UserId = 11 },
                new UserContact { Id = 19, NotificationStatus = true, ContactId = 11, UserId = 9 },
                //proothe(18) vertegro(3)
                new UserContact { Id = 20, NotificationStatus = true, ContactId = 18, UserId = 3 },
                new UserContact { Id = 21, NotificationStatus = true, ContactId = 3, UserId = 18 },
                //vlad1or(1) kntrl552(6)
                new UserContact { Id = 22, NotificationStatus = true, ContactId = 1, UserId = 6 },
                new UserContact { Id = 23, NotificationStatus = true, ContactId = 6, UserId = 1 },
                //vertegro(3) havaily(12)
                new UserContact { Id = 24, NotificationStatus = true, ContactId = 3, UserId = 12 },
                new UserContact { Id = 25, NotificationStatus = true, ContactId = 12, UserId = 3 },
                //leared(7) yetrome1992(17)
                new UserContact { Id = 26, NotificationStatus = true, ContactId = 7, UserId = 17 },
                new UserContact { Id = 27, NotificationStatus = true, ContactId = 17, UserId = 7 },
                //scance2000(9) donew1987(15)
                new UserContact { Id = 28, NotificationStatus = true, ContactId = 15, UserId = 9 },
                new UserContact { Id = 29, NotificationStatus = true, ContactId = 9, UserId = 15 },
                //andow1994(14) lifare(19)
                new UserContact { Id = 30, NotificationStatus = true, ContactId = 14, UserId = 19 },
                new UserContact { Id = 31, NotificationStatus = true, ContactId = 19, UserId = 14 }
                );
        } 
        public DbSet<User> Users { get; set; }

        public DbSet<ChatMute> ChatMutes { get; set; }
        public DbSet<MessageView> MessageViews { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ReplyMessage> ReplyMessages { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<UserContact> UserContacts { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserSetting> UserSettings { get; set; }

        public DbSet<BugReport> BugReports { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
    }
}
