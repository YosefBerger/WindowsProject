using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
 

namespace BL
{
    // The BL only has functionality
    public class MyBL
    {
        IDAL dal = FactoryDal.getInstance();
        public List<Trainee> allTrainees()
        {
            // Some verification validations and more...
            // anything else
            // and so on...
            return dal.getAllTrainees();
        }
    }
}
