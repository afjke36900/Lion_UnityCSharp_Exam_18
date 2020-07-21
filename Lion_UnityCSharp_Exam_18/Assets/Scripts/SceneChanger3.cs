using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question2");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question4");
        }
    }

    public void BackScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void NextScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
