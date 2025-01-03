﻿using Project.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.SingletonPattern
{
    public class DbTool
    {
        DbTool() { }

        static MyContext _dbInstance;

        public static MyContext DbInstance
        {
            get
            {
                if( _dbInstance == null ) _dbInstance = new MyContext();
                return _dbInstance;
            }
        }
    }
}
