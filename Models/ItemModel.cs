﻿using System;
namespace RankingAppNET6.Models
{
	public class ItemModel
	{
		public int Id { get; set; }

		public string Title { get; set; } = string.Empty;

		public int ImageId { get; set; }

		public int Ranking { get; set; }

		public int ItemType { get; set; }

    }
}

