using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField] private Transform[] respawnLocations;
    private int respawnPos = 0;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private int playerInGame = 1;
    
    void Start()
    {
        for(int i = 0; i < playerInGame; i++)
        {
            Quaternion R = Quaternion.identity;
            var playerObj = Instantiate(playerObject, respawnLocations[respawnPos].position, R);
            respawnPos += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(respawnPos == respawnLocations.Length)
        {
            respawnPos = 0;
        }
    }
}
