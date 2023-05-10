using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_tentacle : MonoBehaviour
{
    public GameObject tentacle;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true){
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-2.5f, 2f);
            GameObject newTentacle = Instantiate(tentacle, new Vector3(10, rand, 0), Quaternion.identity);
            Destroy(newTentacle, 10);
        }
    }
}
