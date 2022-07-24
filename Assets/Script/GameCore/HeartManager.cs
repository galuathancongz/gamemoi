using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    [SerializeField] GameObject popupGameOver;
   
    [SerializeField] Text text;
    static public int numberHeart=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeNumberHeart();
        if (numberHeart == 0)
        {
            
            popupGameOver.SetActive(true);
           
        }
    }
    void ChangeNumberHeart()
    {
        text.text = numberHeart.ToString();
    }
}
