using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Currencies : MonoBehaviour
{
    public float gold = 0;
    public TextMeshProUGUI goldtext;


    private void Update()
    {
        goldtext.text = "Gold: " + gold;
    }
}
