using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSpawning : MonoBehaviour
{

    public GameObject deadPlayer;
    public GameObject livePlayer;
    public GameObject spawner;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            spawnDeadBody();
            movePlayer();
        }
        
    }
    public void spawnDeadBody()
    {   
        Vector3 uusPos = livePlayer.transform.position;
        uusPos.y += 15;
        uusPos.x -=4;
        for(int x = 0;x<20;x++){
            uusPos.y += 1;
            Instantiate(deadPlayer, uusPos, Quaternion.identity);
        }
        
    }
    public void movePlayer()
    {
        livePlayer.transform.position = transform.position;
    }
}
