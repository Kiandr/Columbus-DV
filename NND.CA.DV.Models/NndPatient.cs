using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  NND.CA.Common.Model;

namespace NND.CA.DV.Models
{
    // this is the basic model that is being used from here all the way to the iOS devices. All patients related data should be located in this class. The schema of the DB shall also mimic this data model too.
    public class NndPatient: BaseModel
    {
        // email address
        // phone number the same as procura
        // address 
        // name
        // lastname
        // gendre 
        // public CLLocation Patient { get; set; }
        
    }
}
