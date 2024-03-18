using UnityEngine;

public class Menu : MonoBehaviour {

    public void StartGame()
    {
        SceneController.instance.LoadScene("GameScene");
    }
    public void GoToSettings() {
        SceneController.instance.LoadScene("GeneralSettingsScene");
    }

    public void GoToRanking() {
        SceneController.instance.LoadScene("RankingScene");
    }
    public void GoToMenu() {
        SceneController.instance.LoadScene("MenuScene");
    }
}
