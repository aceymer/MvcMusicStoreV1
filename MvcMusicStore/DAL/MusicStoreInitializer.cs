using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.DAL
{
    public class MusicStoreInitializer : System.Data.Entity.CreateDatabaseIfNotExists<MvcMusicStoreContext>
    {
        protected override void Seed(MvcMusicStoreContext context)
        {
            var genres = new List<Genre>
            {
                new Genre{Description="Cool1", Name="Cool Songs1"},
                new Genre{Description="Cool2", Name="Cool Songs2"},
                new Genre{Description="Cool3", Name="Cool Songs3"}
            };
            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();

            var artists = new List<Artist>
            {
                new Artist{ArtistId=1, Name="Singer 1"},
                new Artist{ArtistId=2, Name="Singer 2"},
                new Artist{ArtistId=3, Name="Singer 3"},
                new Artist{ArtistId=4, Name="Singer 4"}
            };
            artists.ForEach(s => context.Artists.Add(s));
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album{ArtistId = 1, GenreId = 1, Price = 20M, Title="The Album 1"},
                new Album{ArtistId = 2, GenreId = 1, Price = 101M, Title="The Album 2"},
                new Album{ArtistId = 2, GenreId = 2, Price = 202M, Title="The Album 3"},
                new Album{ArtistId = 3, GenreId = 3, Price = 103M, Title="The Album 4"},
            };

            albums.ForEach(s => context.Albums.Add(s));
            context.SaveChanges();
        }
    }
}