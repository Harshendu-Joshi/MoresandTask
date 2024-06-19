using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.ResizeService;

namespace ImageResizeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageResizeController : ControllerBase
    {
        private readonly ILogger<ImageResizeController> _logger;
        private readonly IResizeService _resizeService;

        public ImageResizeController(ILogger<ImageResizeController> logger, IResizeService resizeService)
        {
            _logger = logger;
            _resizeService = resizeService;
        }

        [HttpPost]
        [Route("ResizeWithEffects")]
        public async Task<IEnumerable<string>> ResizeWithEffects(IEnumerable<RequestInfo> requestInfos)
        {
            return await _resizeService.ResizeImage(requestInfos);

        }
    }
}