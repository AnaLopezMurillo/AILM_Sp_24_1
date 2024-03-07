using UnityEngine;
using UnityEngine.SceneManagement; // Make sure to include this namespace

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}