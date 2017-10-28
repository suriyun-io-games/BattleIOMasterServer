using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameNetworkManagerWithMsf : GameNetworkManager
{
    public override void OnServerDisconnect(NetworkConnection conn)
    {
        base.OnClientDisconnect(conn);
        var ioGamesRoom = GetComponent<IOGamesRoom>();
        if (ioGamesRoom != null)
            ioGamesRoom.ClientDisconnected(conn);
    }
}
