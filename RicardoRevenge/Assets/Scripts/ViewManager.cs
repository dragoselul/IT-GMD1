using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewManager : MonoBehaviour
{
    public void PlayScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
    
    public void UnloadScene(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
