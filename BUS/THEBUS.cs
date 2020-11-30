using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheBUS
    {
        TheDAO theDAO = new TheDAO();
        public List<TheDTO> DSTHE()
        {
            return theDAO.DSTHE();
        }
    }
}
