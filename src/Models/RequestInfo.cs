using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class RequestInfo
    {
        public ImageInfo ImageInfo { get; set; }
        public IEnumerable<BaseEffectInfo> Effects { get; set;}    
    }
}