using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barebones.MasterServer;

public class UIMainMenuWithMsf : UIMainMenu
{
    public UINetworkRoom networkRoomDialog;
    public void OnClickRoomList()
    {
        if (networkRoomDialog != null)
            networkRoomDialog.Show();
    }

    public void OnClickDedicate()
    {
        var master = FindObjectOfType<MasterServerBehaviour>();
        master.StartServer();
        var spawner = FindObjectOfType<SpawnerBehaviour>();
        spawner.StartSpawner();
    }
}
