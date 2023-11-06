using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xVlaue = 0.002f;
    //[SerializeField] float yValue = 0f;
    //[SerializeField] float zValue = 0f;
    [SerializeField] float speedVal = 10f;
    // Start is called before the first frame update
    void Start()
    {
        gameInstuc(); 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(xVlaue, yValue, zValue);
        //transform.Translate(Input.GetAxis("Horizontal"), yValue, Input.GetAxis("Vertical"));
        float moveHori = Input.GetAxis("Horizontal") * Time.deltaTime * speedVal;
        float moveVert = Input.GetAxis("Vertical") * Time.deltaTime * speedVal;  
        transform.Translate(moveHori, 0, moveVert);

    }
    void gameInstuc()
    {
        Debug.Log("HI WELOCOME TO THE GAME");
        Debug.Log("ALL THE BEST !! ");  
    }


}
