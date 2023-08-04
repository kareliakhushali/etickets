using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Data.Base
{
   public interface IEntityBase
    {
        // Now In all the controller we have Id for all of them so make a commom interface
        int Id { get; set; }
    }
}
