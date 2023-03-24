using UnityEngine.SceneManagement;
using UnityEngine;

public class UnToggle : MonoBehaviour
{
    public int gameStartScene;

    public void UnToggleScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

}
