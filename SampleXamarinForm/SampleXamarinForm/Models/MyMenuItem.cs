﻿using System;
namespace SampleXamarinForm.Models
{
	public class MyMenuItem
	{
		public MyMenuItem()
		{
			TargetType = typeof(MyMenuItem);
		}

		public int Id { get; set; }
		public string Title { get; set; }
		public Type TargetType { get; set; }
		public string ImageIcon { get; set; }
	}
}

