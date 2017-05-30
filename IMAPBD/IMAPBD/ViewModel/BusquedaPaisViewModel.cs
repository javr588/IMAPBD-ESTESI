using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMAPBD.Models;

namespace IMAPBD.ViewModel
{
    public class BusquedaPaisViewModel
    {
        public List<LugarCalModel> BusquedaPais { get; set; }

        public BusquedaPaisViewModel()
        {
            BusquedaPais = new List<LugarCalModel>();     
        }
    }
}