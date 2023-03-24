using UnityEngine.SceneManagement;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public int gameStartScene;

    public void ToggleScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
