using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Services.PlugIns
{
    public class AdobePlugin : IPlugin
    {
        public async Task<string> ApplyBlurEffect(BlurEffectInfo effectInfo, string ImageBase64)
        {
            //Apply Effect
            // use effectInfo.Blurpixels
            return ImageBase64;
        }

        public async Task<string> ApplyGrayScaleEffect(GrayScaleEffectInfo effectInfo, string ImageBase64)
        {
            //Apply Effect
            // use effectInfo.GrayScaleEffectPercentage
            return ImageBase64;
        }

        public async Task<string> ApplyRetroPhotoEffect(RetroPhotoEffectInfo effectInfo, string ImageBase64)
        {
            //Apply Effect
            //Use effectInfo.RetroPhotoPercentage              
            return ImageBase64;
        }
    }
}