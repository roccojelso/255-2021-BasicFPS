using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Singleton design pattern
    private static Inventory _main;

    public static Inventory main{
        get { return _main;  }
        private set { _main = value;  }
    }

    public bool hasKey = false;

    private void Start()
    {
        if (main == null)
        {

            _main = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }


    }



}
