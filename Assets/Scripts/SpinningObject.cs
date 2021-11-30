using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(45, 45, 45 * Time.deltaTime * 0.01f); //rotates 50 degrees per second around z axis
    }
}
