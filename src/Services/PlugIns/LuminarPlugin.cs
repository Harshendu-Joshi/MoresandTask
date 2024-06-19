using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Services.PlugIns
{
    public class LuminarPlugin : IPlugin
    {
        public Task<string> ApplyBlurEffect(BlurEffectInfo effectInfo, string ImageBase64)
        {
            //Apply Effect
            // use effectInfo.Blurpixels
            return Task.FromResult(ImageBase64);
        }

        public Task<string> ApplyGrayScaleEffect(GrayScaleEffectInfo effectInfo, string ImageBase64)
        {
            //Apply Effect
            // use effectInfo.GrayScaleEffectPercentage
            return Task.FromResult(ImageBase64);
        }

        public Task<string> ApplyRetroPhotoEffect(RetroPhotoEffectInfo effectInfo, string ImageBase64)
        {
            //Apply Effect
            //Use effectInfo.RetroPhotoPercentage              
            return Task.FromResult(ImageBase64);
        }
    }
}