using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;


public class RankingController : MonoBehaviour {
    [SerializeField] TMP_Text[] playerNames;
    [SerializeField] TMP_Text[] playerTimes;
    string dataFilePath = "ranking.json";

    void Start() {
        SaveData();
        ReadData();
    }

    public void SaveData() {
        //PlayerDataList playerDataList = new PlayerDataList(new List<PlayerData>());
        //PlayerData player1Data = new PlayerData("Abby", 69);
        //PlayerData player2Data = new PlayerData("Abby", 96);
        //playerDataList.playerData.Add(player1Data);
        //playerDataList.playerData.Add(player2Data);
        //foreach (PlayerData playerData in playerDataList.playerData)
        //{
        //    Debug.Log(JsonUtility.ToJson(playerDataList, true));
        //}

        //File.WriteAllText(dataFilePath, JsonUtility.ToJson(playerDataList, true));
        List<PlayerData> playersList = new List<PlayerData>();
        playersList.Add(new PlayerData("Abby", 39));
        playersList.Add(new PlayerData("Bobby", 96));

        PlayerDataList playerDataList = new PlayerDataList();
        playerDataList.playerData = playersList;
        foreach (PlayerData playerData in playersList)
        {
            Debug.Log(playerData.Name);
        }
        string jsonData = JsonUtility.ToJson(playerDataList, true);
        File.WriteAllText(dataFilePath, jsonData);
        //File.Close
    }

    public void ReadData() {
        if (File.Exists(dataFilePath)) {
            string jsonData = File.ReadAllText(dataFilePath);
            PlayerDataList playerDataList = JsonUtility.FromJson<PlayerDataList>(jsonData);
            foreach (PlayerData playerData in playerDataList.playerData)
            {
                Debug.Log(playerData.Name + " " + playerData.Time);
            }
            //SetData(playerData);
        }
    }

    //public void SetData(PlayerData playerData) {
    //    inputField.text = playerData.playerName;
    //    slider.value = playerData.fuelQuantity;
    //}

    //public void UpdateFuelText() {
    //    fuelText.text = slider.value.ToString();
    //}
}