using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger4 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question3");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question5");
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
