using Microsoft.Owin;
using MvcMusicStore.DAL;
using MvcMusicStore.Models;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(MvcMusicStore.Startup))]
namespace MvcMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Database.SetInitializer(new MusicStoreInitializer());
            MvcMusicStoreContext c = new MvcMusicStoreContext();
            c.Database.Initialize(true);
        }
    }
}
