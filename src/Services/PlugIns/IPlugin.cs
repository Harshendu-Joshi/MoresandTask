using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Services.PlugIns
{
    public interface IPlugin
    {
        Task<string> ApplyBlurEffect(BlurEffectInfo effectInfo,string ImageBase64);

        Task<string> ApplyRetroPhotoEffect(RetroPhotoEffectInfo effectInfo,string ImageBase64);

        Task<string> ApplyGrayScaleEffect(GrayScaleEffectInfo effectInfo,string ImageBase64);
    }
}