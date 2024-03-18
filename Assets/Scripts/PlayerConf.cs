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
        List<PlayerData> playersList = new List<PlayerData>();
        playersList.Add(new PlayerData("Abby", 39));
        playersList.Add(new PlayerData("Bobby", 96));

        PlayerDataList playerDataList = new PlayerDataList();
        playerDataList.playerData = playersList;
      
        string jsonData = JsonUtility.ToJson(playerDataList, true);
        PlayerPrefs.SetString("PlayerList", jsonData);

        File.WriteAllText(dataFilePath, jsonData);
    }

    public void ReadData() {
        string json = PlayerPrefs.GetString("PlayerList");
        if (File.Exists(dataFilePath)) {
            string jsonData = File.ReadAllText(dataFilePath);
            PlayerDataList playerDataList = JsonUtility.FromJson<PlayerDataList>(jsonData);
            SetData(playerDataList);
        }
    }

    public void SetData(PlayerDataList playerDataList)
    {
        for(int i = 0; i < playerDataList.playerData.Count; i++)
        {
            playerNames[i].text = playerDataList.playerData[i].name;
            playerTimes[i].text = $"{playerDataList.playerData[i].time} secs.";
        }
       
    }

   
}