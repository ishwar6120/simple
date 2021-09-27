using KalingaManagementSystem.DataAccessLayer;
using KalingaManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaManagementSystem.BusinessLogicLayer
{
    public class BusinessLogic
    {
        public static DataAccess data = null;
        public int AddCampusMind(User user)
        {
            data = new DataAccess();
            var ans = data.AddCampusMind(user);
            return ans;
        }
    }
}
