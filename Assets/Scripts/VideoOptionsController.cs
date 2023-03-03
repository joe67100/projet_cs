using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOptionsController : MonoBehaviour
{
    public Toggle fullScreenToggle;
    private void Start()
    {
        // Charge l'état actuel du Toggle à partir de PlayerPrefs (par défaut false si pas de clé)
        fullScreenToggle.isOn = PlayerPrefs.GetInt("fullScreenToggle", 0) == 1;
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        // Stocke l'état actuel du Toggle dans PlayerPrefs
        PlayerPrefs.SetInt("fullScreenToggle", isFullScreen ? 1 : 0);
        PlayerPrefs.Save();
    }
}
