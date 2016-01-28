using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeColor : MonoBehaviour
{
    public int selectedCube = -1;
	public int numOfCubes = 0;
	public List<GameObject> cubeList;
	public GameObject c;
	//private int dayOfTheWeek;

    // Use this for initialization
    private void Start() {

		CubeData cubeDatas = new CubeData ();
		numOfCubes = cubeDatas.numOfCubes();
		//cubeList = GameObject.Find ("Cube" + 0);
		//Debug.Log (x);
		
	}

    // Update is called once per frame
    private void Update()
    {
        ColorData cols = new ColorData();



        for (int i = 0; i < numOfCubes; i++) {
            GameObject o = GameObject.Find("Cube" + i);
            o.GetComponent<Renderer>().material.color = cols.GetAColorToUse(i);
        }
        



        if (Input.GetButtonDown("Jump"))
            set_scale_of_cubes();
    }

	private int childrenCube(int cubes)
	{
		/*
		foreach (Transform child in transform)
			if ( 

*/
		return 0;
		}


    private void set_scale_of_cubes()
    {
        GameObject o;
		if (selectedCube >= numOfCubes-1) 
		{
			o = GameObject.Find("Cube" + selectedCube);
			o.transform.localScale = new Vector3(1, 1, 1);
			selectedCube = -1;
		}

        if (selectedCube > -1)
        {

			o = GameObject.Find("Cube" + selectedCube);
            o.transform.localScale = new Vector3(1, 1, 1);
        }
		selectedCube++;
		o = GameObject.Find("Cube" + selectedCube);
        o.transform.localScale = new Vector3(1, 2, 1);
    }

    public float yOfCube(int cubeNumber)
    {
		GameObject ob = GameObject.Find("Cube" + selectedCube);
        return ob.transform.localScale.y;
    }
}

public class ColorData
{
    public Color GetAColorToUse(int indexOfTheColorToGet) {
        List<Color> color_list = new List<Color>();
			color_list.Add (new Color (1, 0, 0));
			color_list.Add (new Color (.7f, .7f, 0));
			color_list.Add (new Color (0, 1, 0));
			color_list.Add (new Color (0, .3f, 1));
			color_list.Add (new Color (0, 1, 1));
			color_list.Add (new Color (1, 1, 1));
        return color_list[indexOfTheColorToGet];
    }
}

public class CubeData
{

	public int numOfCubes()
	{		
		int numOfCubes = 0;
		GameObject o;
		do
		{
			o = GameObject.Find("Cube" + numOfCubes);
			if (o != null) {
				numOfCubes++;
			}
		}while(o != null);

		return numOfCubes;
	}

    // When we find a cube, we should put its data in here for tidier access
}
