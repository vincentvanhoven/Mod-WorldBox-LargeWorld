using NeoModLoader.api;
using LargeWorldMod.Content;

namespace LargeWorldMod;

public class LargeWorldMod : BasicMod<LargeWorldMod>
{
    protected override void OnModLoad()
    {
        CustomMapSize.init();
    }
}