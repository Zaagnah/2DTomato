using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.U2D;

public class HatHat : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] DownObj;
    //public Sprite[] spriteList;
    public SpriteRenderer sprite;
  
  
    private void SpawnTarget()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomDrop = Random.Range(0, DownObj.Length);
        //int randomSprite = Random.Range(0, spriteList.Length);

        ////sprite.sprite=Instantiate(spriteList[randomSprite], spawnPoints[randomIndex].position, Quaternion.identity);
        
    
            
           GameObject hat =  Instantiate(DownObj[randomDrop], spawnPoints[randomIndex].position, Quaternion.identity);
            hat.transform.SetParent(transform);


    }

    // Update is called once per frame
    void Start()
    {
        
        SpawnTarget();
        Debug.Log("wdad");
        


    }

}
