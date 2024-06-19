using Models;
using Services.PlugIns;

namespace Services.Effect
{
    public class EffectsServices : IEffectsServices
    {
        private readonly IPlugin _pluginService;

        public EffectsServices(IPlugin pluginService)
        {
            _pluginService = pluginService;
        }

        public async Task<string> ApplyEffects(string ImageBase64, IEnumerable<BaseEffectInfo> effects)
        {
            foreach (var effect in effects)
            {
                switch (effect.EffectType)
                {
                    case EffectTypes.RetroPhoto:
                        ImageBase64 = await _pluginService.ApplyRetroPhotoEffect(effect as RetroPhotoEffectInfo, ImageBase64);
                        break;
                    case EffectTypes.BlurImage:
                        ImageBase64 = await _pluginService.ApplyBlurEffect(effect as BlurEffectInfo, ImageBase64);
                        break;
                    case EffectTypes.GarayScale:
                        ImageBase64 = await _pluginService.ApplyGrayScaleEffect(effect as GrayScaleEffectInfo, ImageBase64);
                        break;
                }
            }
            return ImageBase64;
        }
    }
}