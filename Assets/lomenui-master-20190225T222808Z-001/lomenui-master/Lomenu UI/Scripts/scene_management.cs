using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_management : MonoBehaviour {

    public void loadScene(string name)
    {
        name = "abc1";
        SceneManager.LoadScene(name);
    }

}
