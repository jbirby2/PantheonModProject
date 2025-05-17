using MelonLoader;

namespace PantheonModProject;

public class ModMain : MelonMod
{
    public static string PantheonModProjectSetting;
    
    public override void OnInitializeMelon()
    {
        var category = MelonPreferences.CreateCategory("PantheonModProject");
        PantheonModProjectSetting = category.CreateEntry("PantheonModProjectSetting", "PantheonModProjectValue").Value;
        category.SaveToFile(false);


    }
}