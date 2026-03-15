using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;

    public void StartGame()
    {
        Debug.Log("Game Started");
    }

    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}