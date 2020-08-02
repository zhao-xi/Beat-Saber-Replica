using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float interval = 1f;
    private float timer;



    // Update is called once per frame
    void Update()
    {
        if(timer > 2f)
        {
            GameObject cube = Instantiate(
                cubes[Random.Range(0,cubes.Length)],
                points[Random.Range(0,points.Length)]
                );
            cube.AddComponent<DestroyCube>();
            cube.transform.localPosition = Vector3.zero;
            timer -= interval;
        }
        timer += Time.deltaTime;
    }
}
