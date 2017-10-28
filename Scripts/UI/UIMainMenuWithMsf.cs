using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barebones.MasterServer;
using Barebones.Networking;

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
    }
}
