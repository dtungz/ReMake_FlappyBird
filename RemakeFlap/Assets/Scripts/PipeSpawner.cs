using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 10f;
    [SerializeField] private float _heighRange = 0.45f;
    [SerializeField] GameObject _pipe;

    private float _timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0,Random.Range(-_heighRange,1+_heighRange));
        GameObject pipe = Instantiate(_pipe,spawnPos,Quaternion.identity);

        Destroy(pipe,10f);
    }

}
