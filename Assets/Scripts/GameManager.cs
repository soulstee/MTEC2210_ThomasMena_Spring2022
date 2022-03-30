using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject carPrefab;
    public Transform[] carSpawnPoints;
    public List<Color> TintColors;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCar(); 
        }

        Color c = TintColors[Random.Range(0, TintColors.Count)];

        GetComponent<Renderer>().material.color = c;
        
    }

    void SpawnCar()
    {
        int index = Random.Range(0, carSpawnPoints.Length);
        Vector3 spawnPos = carSpawnPoints[index].position;

        GameObject car = Instantiate(carPrefab, spawnPos, Quaternion.identity);


        int dirModifier = (index > 2) ? -1 : 1;

        car.GetComponent<CarMovement>().speed = Random.Range(3.0f, 6.0f) * dirModifier;

        if(gameObject.transform.position.x >= 25)
        {
            transform.position = spawnPos;
        }
    }
}