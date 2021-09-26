using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models
{
    public class Mapper
    {
        public static RestService.Models.CatModel Map(Data.Entities.Cat cat)
        {
            return new RestService.Models.CatModel()
            {
                Id = cat.Id,
                Name = cat.Name,
                Dob = cat.Dob,
                GenderId=cat.GenderId,
                Gender = cat.Gender.Name,
                CatTypeId=cat.CatType,
                CatType = cat.catType1.Name,
                FurTypeId=cat.FurType,
                FurType = cat.FurType1.Name,
                legLength = cat.legLength,
                ribCage = cat.ribcage
            };
        }
        public static Data.Entities.Cat Map(RestService.Models.CatModel cat)
        {
            return new Data.Entities.Cat()
            {
                Id = cat.Id,
                Name = cat.Name,
                Dob = cat.Dob,
                legLength = cat.legLength,
                ribcage = cat.ribCage,
                GenderId = cat.GenderId,
                CatType = cat.CatTypeId,
                FurType = cat.FurTypeId
            };
        }
    }
}