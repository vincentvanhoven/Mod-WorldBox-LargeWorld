using NeoModLoader.General;
using System;
using UnityEngine;

namespace LargeWorldMod.Content;

internal static class CustomMapSize
{
    public static WorldTemplatesWindow window;
    public static SpriteTextureLoader textureLoader;


    public static void init()
    {

        AssetManager.map_sizes.add(new MapSizeAsset
        {
            id = "leocapriless",
            size = 18,
            path_icon = "iconLeocapri-less",
            show_warning = true
        });

        AssetManager.map_sizes.add(new MapSizeAsset
        {
            id = "leocapri",
            size = 25,
            path_icon = "iconLeocapri",
            show_warning = true
        });

        AssetManager.map_sizes.add(new MapSizeAsset
        {
            id = "leocaprier",
            size = 40,
            path_icon = "iconLeocapri-er",
            show_warning = true
        });

        Config.maxMapSize = "leocaprier";

        AssetManager.map_sizes.init();
    }
}