using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Controler
{
    public class ComplainController
    {
        public void AddComplain(Complain s)
        {
            Complains cls = new Complains();
            cls.AddComplain(s);
        }

        public List<Complain> GetAllComplain()
        {
            Complains ps = new Complains();
            List<Complain> complainList = ps.GetAllComplain();
            return complainList;
        }
    }
}
