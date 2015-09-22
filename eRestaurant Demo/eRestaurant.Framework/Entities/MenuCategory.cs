﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class MenuCategory
    {
        [Key] //this aattribut identifies the MenuCategoryID as mapping to a PK.
        public int MenuCategoryID { get; set; }
        public string Description { get; set; }
        
        //Navigation Properties
        public virtual ICollection<Item> Items { get; set; }
    }
}
