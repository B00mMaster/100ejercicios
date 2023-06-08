using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
   
       public float speed;

    private Rigidbody rb;

   

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 vector3 = new Vector3(Horizontal, Vertical, 0);
       transform.Translate(vector3*speed);

        Vector3 pos = transform.position;
        pos.x=Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
