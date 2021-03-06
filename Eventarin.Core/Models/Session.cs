﻿using System;
using Xamarin.Forms;

namespace Eventarin.Core.Models
{
	public class Session
	{

		public Session()
		{
		}
		[SQLite.Net.Attributes.PrimaryKey]
        public int Id
        {
            get;
            set;
        }
		public string Title
		{
			get;
			set;
		}

        public string Abstract
        {
            get;
            set;
        }


		public string Summary
		{
			get;
			set;
		}

		public string Location
		{
			get;
			set;
		}

        public string Track
        {
            get;
            set;
        }


		public string Sponsor
		{
			get;
			set;
		}


		public string Speakers
		{
			get;
			set;
		}

		public string Speaker_Id
		{
			get;
			set;
		}




        public DateTime Begins
        {
            get;
            set;
        }

        public DateTime Ends
        {
            get;
            set;
        }

    

		public bool IsFavorite
		{
			get;
			set;
		}

		public string FavoriteMessage
		{
			get
			{
				if (IsFavorite)
				{
					return "Saved as a Favorite";
				}
				else
				{
					return "Add to Favorites";
				}
			}
		}

        
		public ImageSource FavoriteImage
		{
			get
			{
				if (IsFavorite)
				{
					return ImageSource.FromFile("star_gold45");
				}
				else
				{
					return ImageSource.FromFile("star_grey45");
				}
			}
		}

        public ImageSource HeadshotDisplayUrl
		{
			get
			{
					return ImageSource.FromFile("NoAvatar.png");
			}
		}

	}
}

