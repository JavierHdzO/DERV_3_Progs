using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody billete;
    public float angle = 0f;
    void Start()
    {
        billete = GetComponent<Rigidbody>();

        billete.constraints = RigidbodyConstraints.FreezePositionY;
    }

    // Update is called once per frame
    void Update()
    {
        billete.transform.Rotate(0, angle, 0);
        angle = angle + 1f;
        if (angle == 181f)
        {
            angle = 0f;
        }
    }
}
