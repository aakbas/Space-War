using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfigs;
    int startingWave = 0;




    // Start is called before the first frame update
    void Start()
    {
        var currentWave = waveConfigs[startingWave];
        StartCoroutine(SpawnAllEnemiesInWave(currentWave));
    }

    private  IEnumerator SpawnAllEnemiesInWave(WaveConfig currentWave)
    {
        for (int i = 0; i < currentWave.GetNumberOfEnemies(); i++)
        {
          var newEnemy=   Instantiate(
          currentWave.GetEnemyPrefab(),
          currentWave.GetWaypoints()[0].transform.position,
          Quaternion.identity
          );
            newEnemy.GetComponent<EnemyPathing>().setWaveConfig(currentWave);
            yield return new WaitForSeconds(currentWave.GetTimeBetweenSpawns());

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
