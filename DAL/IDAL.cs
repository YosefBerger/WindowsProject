﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        bool addTrainee(Trainee tr);
        bool removeTrainee(Trainee tr);
        List<Trainee> //??????????????
    }
}
