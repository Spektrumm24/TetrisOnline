using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform position1;
    public Transform position2;

    private void Start()
    {
        
        int playerNum = PhotonNetwork.CountOfPlayersInRooms;

        Vector3 coord1 = position1.position;
        Vector3 coord2 = position2.position;

        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, coord1, Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(playerPrefab.name, coord2, Quaternion.identity);
        }
            
    }
}
