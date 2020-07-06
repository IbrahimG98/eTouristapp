using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Database
{
    public class Data
    {

        public static void Seed(eTourist1Context context)
        {
            context.Database.Migrate();

            //add init
        }
    }
}
