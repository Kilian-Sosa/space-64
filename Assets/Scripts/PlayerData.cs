using System;
using System.Collections.Generic;

public class PlayerData {

    private string name;
    private int time;

    public PlayerData(string name, int time) {
        this.name = name;
        this.time = time;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Time
    {
        get { return time; }
        set { time = value; }
    }
}

[Serializable]
public class PlayerDataList
{
    public List<PlayerData> playerData;

    //public PlayerDataList(List<PlayerData> data)
    //{
    //    playerData = data;
    //}
}
