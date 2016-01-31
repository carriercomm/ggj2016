﻿using UnityEngine;

public class SceneLoader : Singleton<SceneLoader>
{
    void Awake()
    {
        if (FindObjectsOfType<SceneLoader>().Length > 1) {
            Destroy(gameObject);
            return;
        }

        if (Application.loadedLevelName != "Loader") {
            Application.LoadLevelAdditive("Loader");
        } else {
            Application.LoadLevelAdditive("Level_0");
        }
    }
}
