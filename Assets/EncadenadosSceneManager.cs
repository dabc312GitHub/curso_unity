using System.Collections.Generic;
using UnityEngine;

public class EncadenadosSceneManager : MonoBehaviour
{
    public GameObject Player;

    [Header("Properties Dron Bot")]
    public GameObject DronBot;
    public List<GameObject> EnemyBots;
    
    [Header("Keys Objects")]
    public GameObject PrefabKey;
    public int PrefabKeyTotal = 5;
    public List<Transform> L_RefPrefabKeys;
    private List<int> L_IndexPositionKey = new List<int>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var indexRestriction = 0;
        L_IndexPositionKey.Add(-1);
        while (indexRestriction < PrefabKeyTotal)
        {
            var tempRandom = (Random.Range(0, 1000000)) % L_RefPrefabKeys.Count;
            if (!L_IndexPositionKey.Contains(tempRandom))
            {
                Respawn(L_RefPrefabKeys[tempRandom]);
                L_IndexPositionKey.Add(tempRandom);
                indexRestriction++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Respawn(Transform ref_prefabKey)
    {
        Instantiate(PrefabKey, ref_prefabKey.position, Quaternion.identity);
    }
}
