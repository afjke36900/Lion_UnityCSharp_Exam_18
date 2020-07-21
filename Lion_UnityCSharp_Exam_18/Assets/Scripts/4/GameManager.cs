using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject Player;

    private void Start()
    {
        if (Player.transform.position.z > 9)
        {
            GameOverPanel.SetActive(true);
        }
    }
}
