﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barebones.MasterServer;
using Barebones.Networking;

public class UIMainMenuWithMsf : UIMainMenu
{
    public UINetworkRoom networkRoomDialog;

    public void OnClickRoomList()
    {
        PlayerSave.SetCharacter(SelectCharacter);
        PlayerSave.SetHead(SelectHead);
        PlayerSave.SetWeapon(SelectWeapon);
        if (networkRoomDialog != null)
            networkRoomDialog.Show();
    }

    public void OnClickDedicate()
    {
        PlayerSave.SetCharacter(SelectCharacter);
        PlayerSave.SetHead(SelectHead);
        PlayerSave.SetWeapon(SelectWeapon);
        var master = FindObjectOfType<MasterServerBehaviour>();
        master.StartServer();
    }
}
