using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart_button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
         //EditorSceneManager.LoadScene("a_nice_game");//��������д�Լ�����������
        button.SetActive(false);
    }
}
