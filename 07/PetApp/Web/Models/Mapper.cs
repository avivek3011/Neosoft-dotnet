using Data.Entities;
using Microsoft.SqlServer.Server;
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
        public static Web.Models.CatViewModel MapCVM(Data.Entities.Cat cat)
        {
            return new Web.Models.CatViewModel()
            { 
                Id=cat.Id,
                Name = cat.Name,
                Dob = cat.Dob,
                GenderId = cat.GenderId,
                FurType=cat.FurType,
                CatType=cat.CatType,
                legLength = cat.legLength,
                ribLength = cat.ribcage
            };
        }
        public static Data.Entities.Cat Map(Web.Models.CatViewModel cat)
        {
            return new Data.Entities.Cat()
            {
                Id=cat.Id,
                Name = cat.Name,
                Dob = cat.Dob,
                legLength=cat.legLength,
                ribcage=cat.ribLength,
                GenderId=cat.GenderId,
                CatType=cat.CatType,
                FurType=cat.FurType
            };
        }
    }
}