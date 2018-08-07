using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level_Stage : MonoBehaviour {

    public TextMeshProUGUI Level;
    public TextMeshProUGUI Stage;
    public float level;
    public float stage;
	
	// Update is called once per frame
	void Update () {
        Level.text = "Level - " + level;
        Stage.text = "Stage - " + stage;
	}
}
