using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSvene : MonoBehaviour
{
    public void GoToScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
