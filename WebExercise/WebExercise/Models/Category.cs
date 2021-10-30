﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebExercise.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            TinTucs = new HashSet<TinTuc>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? Levels { get; set; }
        public int? Ordering { get; set; }
        public bool Published { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaDecs { get; set; }
        public string MetaKey { get; set; }
        public string Cover { get; set; }
        public string SchemaMarkup { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<TinTuc> TinTucs { get; set; }
    }
}
