using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : MonoBehaviour 
{
    private Transform cube;
	private void Awake() 
	{
        cube = GetComponent<Transform>();
	}

    private void Start()
    {
        StartCoroutine(Move(MoveFinish));
    }

    private void Update () 
	{
        if (cube.position.x<=10)
        {
            cube.Translate(new Vector3(0.1f, 0f, 0f));
        }
    }

    private void MoveFinish()
    {
        print(cube.name);
    }

    private IEnumerator Move(Action MoveFinish)
    {
        while (cube.position.x<=10)
        {
            yield return null;
        }

        if (MoveFinish!=null)
        {
            MoveFinish();
        }
    }
}
