using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem ;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 moveValue ;
    public float speed ;
    private int count;
    private int numPickups = 5;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public GameObject restart;
    void Start()
    {
        count = 0;
        winText.text = "";
        SetCountText();
    }
    void update()
    {
        

    }

    void OnMove( InputValue value ) 
    {
        moveValue = value . Get < Vector2 >() ;
    }
    
    
    void FixedUpdate () 
    {
        Vector3 movement = new Vector3 ( moveValue.x, 0.0f , moveValue.y) ;
        this.GetComponent<Rigidbody>().AddForce(movement*speed*Time.fixedDeltaTime);
    }

    void OnTriggerEnter ( Collider other)
    {
        if(other.gameObject.tag =="pickup")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    private void SetCountText()
    {
        scoreText.text = "Score:" + count.ToString();
        if(count>= numPickups)
        {
            winText.text = "YOU WIN?(so easy)";
            restart.SetActive(true);
        }
    }

}
