﻿using WebApi.Contexts;
using WebApi.Helpers.Repositories.Base;
using WebApi.Models.Entities;

namespace WebApi.Helpers.Repositories
{
	public class TagRepository : Repository<TagEntity>
	{
		public TagRepository(DataContext context) : base(context)
		{
		}
	}
}
