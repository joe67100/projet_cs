using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOptionsController : MonoBehaviour
{
    public Toggle fullScreenToggle;
    private void Start()
    {
        // Charge l'�tat actuel du Toggle � partir de PlayerPrefs (par d�faut false si pas de cl�)
        fullScreenToggle.isOn = PlayerPrefs.GetInt("fullScreenToggle", 0) == 1;
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        // Stocke l'�tat actuel du Toggle dans PlayerPrefs
        PlayerPrefs.SetInt("fullScreenToggle", isFullScreen ? 1 : 0);
        PlayerPrefs.Save();
    }
}
