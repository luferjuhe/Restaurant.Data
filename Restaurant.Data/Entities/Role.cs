﻿using System;
namespace Restaurant.Data.Entities
{
	public class Role
	{
		public int RoleId { get; set; }
		public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public int CreationUserId { get; set; }
    }
}

