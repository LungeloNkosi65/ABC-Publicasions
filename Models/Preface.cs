using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABC_Publicasions.Models
{
    public class Preface
    {
        public string title { get; set; }
        public List<object> content { get; set; }
        public List<Navigation> navigation { get; set; }
    }
}