using MVCCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrud.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        public DBTool() { }

        static NORTHWNDEntities _dbInstance;
        public static NORTHWNDEntities DBInstance
        {
            get 
            {
                if(_dbInstance == null) _dbInstance = new NORTHWNDEntities();
                return _dbInstance;
            }
        }
    }
}