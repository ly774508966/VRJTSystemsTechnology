using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Socialite.Migrations.CommentDbContext
{

    internal sealed class Configuration : DbMigrationsConfiguration<Socialite.Models.CommentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\CommentDbContext";
        }

        protected override void Seed(Socialite.Models.CommentDbContext context)
        {
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat1", UrlSeo = "Lorem", Description = "Lorem Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat2", UrlSeo = "Duis", Description = "Duis Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat3", UrlSeo = "Nulla", Description = "Nulla Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat4", UrlSeo = "Ipsum", Description = "Ipsum Category" });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "1",
                Title = "Lorem",
                Body = "Lorem ipsum dolor sit amet, sadsafdsfdasfdfadsfadsfasdfsafdsfsdfafsfdsfdafafsfdsafdsfdsaf",
                PostedOn = DateTime.Now,
                Meta = "Lorem",
                UrlSeo = "Lorem",
                Published = true
            });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "2",
                Title = "Dius",
                Body = "Dius ipsum dolor sit amet, sadsafdsfdasfdfadsfadsfasdfsafdsfsdfafsfdsfdafafsfdsafdsfdsaf",
                PostedOn = DateTime.Now,
                Meta = "Dius",
                UrlSeo = "Dius",
                Published = true
            });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "3",
                Title = "Nulla",
                Body = "Nulla ipsum dolor sit amet, sadsafdsfdasfdfadsfadsfasdfsafdsfsdfafsfdsfdafafsfdsafdsfdsaf",
                PostedOn = DateTime.Now,
                Meta = "Nulla",
                UrlSeo = "Nulla",
                Published = true
            });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "4",
                Title = "Ipsum",
                Body = "Ipsum ipsum dolor sit amet, sadsafdsfdasfdfadsfadsfasdfsafdsfsdfafsfdsfdafafsfdsafdsfdsaf",
                PostedOn = DateTime.Now,
                Meta = "Ipsum",
                UrlSeo = "Ipsum",
                Published = true
            });

            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "1", CategoryId = "cat1" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "1", CategoryId = "cat4" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "2", CategoryId = "cat2" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "3", CategoryId = "cat4" });

            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 1, PostId = "1", VideoSiteName = "YouTube", VideoUrl = "https://youtu.be/Xvjnoagk6GU", VideoThumbnail = "https://i1.wp.com/septin911.net/wp-content/uploads/download-video-psy-i-luv-it.jpg?fit=1280%2C720" });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 2, PostId = "1", VideoSiteName = "YouTube", VideoUrl = "https://youtu.be/Xvjnoagk6GU", VideoThumbnail = "https://i1.wp.com/septin911.net/wp-content/uploads/download-video-psy-i-luv-it.jpg?fit=1280%2C720" });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 3, PostId = "1", VideoSiteName = "YouTube", VideoUrl = "https://youtu.be/Xvjnoagk6GU", VideoThumbnail = "https://i1.wp.com/septin911.net/wp-content/uploads/download-video-psy-i-luv-it.jpg?fit=1280%2C720" });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 4, PostId = "1", VideoSiteName = "YouTube", VideoUrl = "https://youtu.be/Xvjnoagk6GU", VideoThumbnail = "https://i1.wp.com/septin911.net/wp-content/uploads/download-video-psy-i-luv-it.jpg?fit=1280%2C720" });
        }
    }
}
