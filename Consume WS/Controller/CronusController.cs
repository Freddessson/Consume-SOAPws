﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Controller
{
    public class CronusController
    {
        public string[][] GetCronusEmployees()
        {
            return CronusDAL.GetCronusEmployees();
        }
     }
}
