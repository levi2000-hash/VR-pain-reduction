using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = obj1.transform.position.x;
        float y = obj1.transform.position.y;
        float z = obj1.transform.position.z;

        obj2.transform.position = new Vector3(x * -1, y, z);
        obj2.transform.rotation = new Quaternion(obj1.transform.rotation.x * -1.0f,
                                            obj1.transform.rotation.y,
                                            obj1.transform.rotation.z,
                                            obj1.transform.rotation.w * -1.0f);
    }
}
