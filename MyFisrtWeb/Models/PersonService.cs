using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFisrtWeb.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class PersonService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Person> List()
        {
            List<Person> list = new List<Models.Person>();
            list.Add(new Person()
            {
                Id = "NV1",
                FirstName = "Loc",
                LastName = "Hoang",
                Address = "qb",
                Email = "hoangloc921999@gmail.com",
                Phone = "12381237"
            });
            list.Add(new Person()
            {
                Id = "NV1",
                FirstName = "Loc",
                LastName = "Hoang",
                Address = "qb",
                Email = "hoangloc921999@gmail.com",
                Phone = "12381237"
            });
            list.Add(new Person()
            {
                Id = "NV1",
                FirstName = "Loc",
                LastName = "Hoang",
                Address = "qb",
                Email = "hoangloc921999@gmail.com",
                Phone = "12381237"
            });
            return list;
        }
    }
}