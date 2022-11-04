using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{   
    public GameObject calabaza;
    float sec = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sec += 1f * Time.deltaTime;
        if (sec>=5)
        {
            sec = 0;
            GameObject go = Instantiate(calabaza);
            float scale = Random.Range(1,3);
            go.transform.position = new Vector3(go.transform.position.x, Random.Range(0.8f, -0.3f), -1f);
            go.transform.localScale = new Vector3(scale,scale,scale);
            Rigidbody2D rbcalabaza = go.GetComponent<Rigidbody2D>();
            rbcalabaza.velocity = new Vector2(-300 * Time.deltaTime,0f);
        }
    }
}
