using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _eggPrefab;
    [SerializeField]
    private Transform[] _spawnPoints;
    private List<GameObject> _eggs = new List<GameObject>();

    IEnumerator SpawnEggsRoutine()
    {
        InstantiateEgg();
         yield return new WaitForSeconds(Random.Range(0.1f, 2f));
        StartCoroutine(SpawnEggsRoutine());
    }
    private void InstantiateEgg()
    {
        _eggs.Add(Instantiate(_eggPrefab, _spawnPoints[Random.Range(0,4)].position, Quaternion.identity, GameObject.FindGameObjectWithTag("EggsContainer").transform));
    }

    public void DespawnEggs()
    {
        for (int i = 0; i < _eggs.Count; i++)
        {
            Destroy(_eggs[i]);
        }
    }
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(SpawnEggsRoutine());
    }
}
