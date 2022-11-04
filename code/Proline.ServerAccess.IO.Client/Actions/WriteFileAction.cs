﻿using CitizenFX.Core;
using Newtonsoft.Json;
using Proline.Resource.Eventing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Proline.Resource.Console;

namespace Proline.ServerAccess.IO.Actions
{
    public class WriteFileAction : ExtendedEvent
    { 
        public WriteFileAction() : base(SAVEFILEHANDLER, false)
        {

        }


        public const string SAVEFILEHANDLER = "SaveFileHandler";
        
    }
}
