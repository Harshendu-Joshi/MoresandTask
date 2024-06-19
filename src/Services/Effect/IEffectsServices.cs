using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Services.Effect
{
    public interface IEffectsServices
    {
        Task<string> ApplyEffects(String ImageBase64,IEnumerable<BaseEffectInfo> effects);
    }
}