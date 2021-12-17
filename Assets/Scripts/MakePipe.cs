using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff = 0.0f;
    float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(3.7f, Random.Range(-1.4f, 3.0f), 0);
            timer = 0.0f;
            Destroy(newPipe, 5.5f);
        }
    }
}
