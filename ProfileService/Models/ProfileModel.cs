using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileService.Models
{
    public class ProfileModel
    {
        public int ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ImageModel ProfileImage { get; set; }
        public string Bio { get; set; }

        public GalleryModel GalleryImages { get; set; } = new GalleryModel();

        //Make sure to not forget to add favorites section
        //public string FavoriteBook { get; set; }
        public List<FavoritesModel> FavoritesList { get; set; } = new List<FavoritesModel>();
        //public string FavoriteMovie { get; set; }
        //public string FavoriteGame { get; set; }

        public ProfileModel()
        {
            FirstName = "Fernando";
            LastName = "Blanco";
            ProfileImage = new ImageModel()
            {
                ImageName = "Profile Pic",
                ImageURL = "..\\Content\\Images\\ProfilePicture\\FBProPic.jpg"
            };
            Bio = "Here's what you need to know about me: " +
                " I am from Puebla, Mexico but I was raised in Utah for almost my entire life." +
                " I love to draw, play guitar, play video games, code, 3D print, read books, watch movies and television." +
                " I tend to sleep a lot when I don't eat." +
                " I take a neutral stance on about most serious subjects like politics, religion, etc." +
                " I love food, just like every other normal human" +
                " That's pretty much what I can put here for now...";
            //FavoriteBook = "The Lightning Thief";
            //FavoriteMovie = "LOTR: Fellowship Of The Ring ";
            //FavoriteGame = "The Witcher 3";

            PopulateFavoritesList();

            PopulateGalleryImages();
        }

        private void PopulateGalleryImages()
        {
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 1",
                ImageURL = "..\\Content\\Images\\GalleryPics\\CancunProPic.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 2",
                ImageURL = "..\\Content\\Images\\GalleryPics\\CoolPic1.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 3",
                ImageURL = "..\\Content\\Images\\GalleryPics\\BarPooling.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 4",
                ImageURL = "..\\Content\\Images\\GalleryPics\\ANightOut.jpg"
            });

            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 5",
                ImageURL = "..\\Content\\Images\\GalleryPics\\AllMightDrawing.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 6",
                ImageURL = "..\\Content\\Images\\GalleryPics\\itsatrap.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 7",
                ImageURL = "..\\Content\\Images\\GalleryPics\\Dancer.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 8",
                ImageURL = "..\\Content\\Images\\GalleryPics\\KH3SoraDrawing.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 9",
                ImageURL = "..\\Content\\Images\\GalleryPics\\NCPic.jpg"
            });
            GalleryImages.Images.Add(new ImageModel()
            {
                ImageName = "Pic 10",
                ImageURL = "..\\Content\\Images\\GalleryPics\\webSnap.png"
            });
        }

        private void PopulateFavoritesList()
        {
            FavoritesList.Add(new FavoritesModel()
            {
                Category = "Book",
                Title = "The Lightning Thief",
                Image = new ImageModel()
                {
                    ImageName = "The Lightning Thief",
                    ImageURL = "..\\Content\\Images\\Favorites\\LTBookCover.jpg"
                }
            });
            FavoritesList.Add(new FavoritesModel()
            {
                Category = "Movie",
                Title = "LOTR: Fellowship Of The Ring",
                Image = new ImageModel()
                {
                    ImageName = "LOTR: Fellowship Of The Ring",
                    ImageURL = "..\\Content\\Images\\Favorites\\LOTR.jpg"
                }
            });
            FavoritesList.Add(new FavoritesModel()
            {
                Category = "Game",
                Title = "The Witcher 3: Wild Hunt",
                Image = new ImageModel()
                {
                    ImageName = "The Witcher 3: Wild Hunt",
                    ImageURL = "..\\Content\\Images\\Favorites\\TW3GameCover.jpg"
                }
            });
        }
    }
}