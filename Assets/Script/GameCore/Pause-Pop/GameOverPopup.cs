using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPopup : MonoBehaviour
{

    
    [SerializeField] Button buttonback;
  
    [SerializeField] Button buttonhelp;
    [SerializeField] GameObject PopUpHelp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        buttonback.onClick.AddListener(ClickToBack);
       
        buttonhelp.onClick.AddListener(ClickToHelp);
    }
    
    void ClickToBack()
    {
        
        SceneManager.LoadScene("SceneHome", LoadSceneMode.Single);
        buttonback.onClick.RemoveListener(ClickToBack);
    }
    
    void ClickToHelp()
    {
        PopUpHelp.SetActive(true);
        buttonhelp.onClick.RemoveListener(ClickToHelp);
    }
}
