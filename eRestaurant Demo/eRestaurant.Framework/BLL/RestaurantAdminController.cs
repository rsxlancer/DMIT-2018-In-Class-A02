using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Framework.DAL;
using eRestaurant.Framework.Entities;
using System.ComponentModel; // needed for [DataObject] and related attribute classes

namespace eRestaurant.Framework.BLL
{
    // Allows our class to be "discovered" by the ObjectDataSource controls in our website
    [DataObject]
    public class RestaurantAdminController
    {

        #region Manage Special Events
        //The ObjectDataSource will do the background communication for CRUD
        //Allows the ObjectDataSourve to see the method as something we can SELECT from
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            //This using statement ensures that our connection to the database is 
            //properle "closed" once we are dome "using" our DAL object.
            // (contect is our DAL object)
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
        
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //First attach the item to the dbContext collection
                var attached = context.SpecialEvents.Attach(item);

                // var matchingWithExistingValues = context.Entry<SpecialEvent>(attached);
                //matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                //context.SaveChanges();

                
                var existing = context.Entry<SpecialEvent>(attached);
                existing.State = System.Data.Entity.EntityState.Modified;
                
                context.SaveChanges();

            }
            //First attacj the item to the dbContext collection
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent item)
        {
            using (var context = new RestaurantContext())
            {
                //first get a reference to the actual item by its primary key
                //find() is a METHOD to look up an utem by its primary key.
                var existing = context.SpecialEvents.Find(item.EventCode);

                //second, remove the item from the database context
                context.SpecialEvents.Remove(existing);

                //lastly, save the changes to the database
                context.SaveChanges();

            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddSpecialEvent(SpecialEvent item)
        {
            using (var context = new RestaurantContext())
            {
                //add the item to dbcontext
                var added = context.SpecialEvents.Add(item);
                //p.s. - we aren't really going to do anything with the variable 'added;
                // i just want you to be aware that the Add() METHOD will return the 
                //newly added object. (this can be useful in other situations, which we will see later)

                //save changes
                context.SaveChanges();
            }
        }
        #endregion
    }
}
