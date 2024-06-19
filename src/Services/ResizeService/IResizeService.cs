using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Services.ResizeService
{
    public interface IResizeService
    {
        Task<List<String>> ResizeImage(IEnumerable<RequestInfo> requestInfos);
    }
}