﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Models;

namespace TradingPlatformTest.Repositories
{
    public interface ICategoryRepository
    {
        public List<SelectListItem> GetAllCategoriesSelectedList();

        public IEnumerable<Category> GetAllCategories();

        public string GetCategoryName(int categoryId);
    }
}
