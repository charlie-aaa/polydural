using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class noiseFilterFactory
{

    public static INoiseFilter CreateNoiseFilter(NoiseSettings settings)
    {
        switch (settings.filterType)
        {
            case NoiseSettings.FilterType.Simple:
                return new simpleNoiseFilter(settings.simpleNoiseSettings);
            case NoiseSettings.FilterType.Ridgid:
                return new ridgitNoiseFilter(settings.ridgidNoiseSettings);
        }
        return null;
    }
}
