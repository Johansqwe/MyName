﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    
      
    public class Information
    {
        public List<Accounts> Accounts;

         public Information()
       {
           Accounts = new List<Accounts>();
           Accounts.Add(new Accounts { Id = 4, Name = "Johannes", Age = 6});
           Accounts.Add(new Accounts { Id = 3, Name = "asd", Age = 5 });
           Accounts.Add(new Accounts { Id = 2, Name = "asdf", Age = 4 });
           Accounts.Add(new Accounts { Id = 1, Name = "123", Age = 1 });


       }

    }
}