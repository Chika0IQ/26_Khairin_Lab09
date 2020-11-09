using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    public float speed;
    public float rotatespeed;

    public float PositionX;
    public float PositionY;
    public float PositionZ;


    public GameObject Text;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        PositionX = gameObject.transform.position.x;
        PositionY = gameObject.transform.position.y;
        PositionZ = gameObject.transform.position.z;

        

        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0,0, Time.deltaTime * speed);
            transform.position += transform.forward * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotatespeed, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotatespeed, 0));
        }

        Text.GetComponent<Text>().text = "Postion: ( " + PositionX + ", " + PositionY + ", " + PositionZ + " )";
        


    }
}
