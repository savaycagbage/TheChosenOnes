using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemySpawner : MonoBehaviour {

    public GameObject Enemy;
    public EnemyStatusz enemy;
    public TextMeshProUGUI Level;
    public TextMeshProUGUI Stage;
    public float level;
    public float stage;
    float time=0;
    public float spawntime;


    void Update () {

        

        if (enemy == null)
        {
            time += Time.deltaTime;

            if (time >= spawntime)
            {
                Instantiate(Enemy);
                enemy = EnemyStatusz.FindObjectOfType<EnemyStatusz>();
                time = 0;
            }
        }
        
            
    }
}
