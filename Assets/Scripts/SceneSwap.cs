﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwap : MonoBehaviour
{
    public string sceneName;
    public void SceneLoad ()
    {
    	SceneManager.LoadScene(sceneName);
    }
}