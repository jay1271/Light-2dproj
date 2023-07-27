using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolManagers : MonoBehaviour
{
    public List<GameObject> platforms;
    private int TotalPlatforms;
    private int CurrentPlatform = 0;
    private void Awake()
    {
        TotalPlatforms = platforms.Count;
    }


    private void Start()
    {
        
    }


}
