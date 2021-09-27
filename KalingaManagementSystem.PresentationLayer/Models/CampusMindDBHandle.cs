using KalingaManagementSystem.BusinessLogicLayer;
using KalingaManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalingaManagementSystem.PresentationLayer.Models
{
    public class CampusMindDBHandle
    {
        public void AddCampusMindDetails(CampusMindModel cmodel)
        {
            BusinessLogic business = new BusinessLogic();
            User user = new User();
            user.Name = cmodel.Name;
            user.DateOfJoin = cmodel.DateOfJoin;
            user.ContactNumber = cmodel.ContactNumber;
            user.Address = cmodel.Address;
            user.LeadId = cmodel.LeadId;
            business.AddCampusMind(user);
        }

        
    }
}