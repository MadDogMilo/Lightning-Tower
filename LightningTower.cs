using MelonLoader;
using BTD_Mod_Helper;
using LightningTower;

[assembly: MelonInfo(typeof(LightningTower.LightningTower), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace LightningTower;

public class LightningTower : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<LightningTower>("LightningTower loaded!");
    }
}