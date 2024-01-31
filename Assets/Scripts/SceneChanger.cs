using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OnClickLoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
