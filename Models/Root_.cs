using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABC_Publicasions.Models
{
    public class Root_
    {
        public Preface Preface { get; set; }
        public Dictionary<string,GenericMap> DictContent { get; set; }

        public Root_()
        {
            DictContent = new Dictionary<string, GenericMap>();
        }
    }
}