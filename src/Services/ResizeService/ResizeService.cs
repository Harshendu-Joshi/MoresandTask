using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.Effect;

namespace Services.ResizeService
{
    public class ResizeService : IResizeService
    {
        private readonly IEffectsServices _effectsServices;

        public ResizeService(IEffectsServices effectsServices)
        {
            _effectsServices = effectsServices;
        }

        public async Task<List<String>> ResizeImage(IEnumerable<RequestInfo> requestInfos)
        {
            List<String> Base64Images = new List<string>();
            foreach (var requestInfo in requestInfos)
            {
                var resizedImage = await ResizeImage(requestInfo.ImageInfo);
                resizedImage = await _effectsServices.ApplyEffects(resizedImage, requestInfo.Effects);
                Base64Images.Add(resizedImage);
            }
            return Base64Images;
        }

        private async Task<string> ResizeImage(ImageInfo imageInfo)
        {
            //Resize Image
            return  imageInfo.ImageBase64;
        }
    }
}