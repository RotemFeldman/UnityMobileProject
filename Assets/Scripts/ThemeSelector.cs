using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSelector : MonoBehaviour
{
    public void ChangeTheme(int themeId)
    {
        UIManager.ThemeId = themeId;
    }

}
