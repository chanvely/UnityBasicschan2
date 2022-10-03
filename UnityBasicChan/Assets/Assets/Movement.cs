using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
       
        // added movement for diagonal direction
        // "t" can be replaced with any key
        // this section moves the character left
        double m = 0.8;
        float diag = (float) m;

        if (Input.GetKey("t"))
        {
            pos.x -= diag * speed * Time.deltaTime;
            pos.y += diag * speed * Time.deltaTime;
        }

        // added movement for diagonal direction
        // "z" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("z"))
        {
            pos.x += diag * speed * Time.deltaTime;
            pos.y -= diag * speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
