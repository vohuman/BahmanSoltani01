using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BahmanSoltani.Models.Data
{
    /// <summary>
    /// A repository for data functions including Insert, Update, Select, Delete
    /// </summary>
    public interface IRepository<T> where T: class
    {
        int Count();
        /// <summary>
        /// Insert new Item to the database
        /// </summary>
        /// <param name="entity">new Item</param>
        /// <returns>an Integer which shows whether the function works correctly or not</returns>
        int Add(T entity);
        /// <summary>
        ///  Update an Item in the database
        /// </summary>
        /// <param name="entity">New value of the Item to be updated</param>
        /// <returns>an Integer which shows whether the function works correctly or not</returns>
        int Update(T entity);
        /// <summary>
        /// Delete an Item in the database
        /// </summary>
        /// <param name="id">ID of the object</param>
        /// <returns>an Integer which shows whether the function works correctly or not</returns>
        int Delete(int id);
        /// <summary>
        /// Delete all records in the database
        /// </summary>
        /// <returns>an Integer which shows whether the function works correctly or not</returns>
        int DeleteAll();
        /// <summary>
        /// Update all records in the database
        /// </summary>
        /// <param name="entity">New value for updating</param>
        /// <returns>an Integer which shows whether the function works correctly or not</returns>
        int UpdateAll(T entity);
        /// <summary>
        /// Getting all records of the Table
        /// </summary>
        /// <returns>an IQueryable of the data model</returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// Getting a specific item by using its ID
        /// </summary>
        /// <param name="id">ID of the item to be selected</param>
        /// <returns>an Entity with the specific ID</returns>
        T Get(int id);
        /// <summary>
        /// Searching in the list of objects by using a 
        /// </summary>
        /// <param name="selector">Func variable and assign a lambda expression to the list</param>
        /// <returns>an IQueryable of the data model</returns>
        IQueryable Search(Func<T, int> selector);

    }
}
