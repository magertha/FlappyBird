using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Kus BirdScript;

    public GameObject Borular;

    public float height;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (!BirdScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-height,height),0), Quaternion.identity);

            yield return new WaitForSeconds(1.3f);
        }
    }
}
