﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aa = EntityApi.Entities;

namespace Business_Logic
{
    public class Mapper
    {   
        public static Models.Allergy Map(Aa.Allergy allergy)
        {
            return new Models.Allergy()
            {
                id = allergy.Id,
                VisitId = allergy.VisitId,
                AllergyName = allergy.AllergyName,
                Notes = allergy.Notes,
            };
        }
        public static Aa.Allergy Map(Models.Allergy allergy)
        {
            return new Aa.Allergy()
            {
                Id = allergy.id,
                VisitId = allergy.VisitId,
                AllergyName = allergy.AllergyName,
                Notes = allergy.Notes,
            };
        }
        public static IEnumerable <Models.Allergy> Map(IEnumerable<Aa.Allergy> allergy)
        {
            return allergy.Select(Map);
        }
    }
}
