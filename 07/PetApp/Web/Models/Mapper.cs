using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace Web.Models
{
    public class Mapper
    {
        public static Web.Models.Cat Map(Data.Entities.Cat cat)
        {
            return new Web.Models.Cat()
            {
                Id = cat.Id,
                Name = cat.Name,
                Dob = cat.Dob,
                Gender = cat.Gender.Name,
                CatType = cat.catType1.Name,
                FurType = cat.FurType1.Name,
                legLength = cat.legLength,
                ribCage = cat.ribcage
            };
        }
    }
}