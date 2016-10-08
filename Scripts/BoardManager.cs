using UnityEngine;
using Random = UnityEngine.Random; 
using System.Collections.Generic;
using System.Collections;

public class BoardManager : MonoBehaviour {

	public class Count
		{
			public int minimum; 			//Minimum value for our Count class.
			public int maximum; 			//Maximum value for our Count class.
			
			
			//Assignment constructor.
			public Count (int min, int max)
			{
				minimum = min;
				maximum = max;
			}
		}

	public int columns = 9, rows = 9;
	
	public GameObject[] arbre;
	public Count rochers= new Count(5,9);
	public Count food = new Count(6,10);
	public GameObject[] fougeres;

	public GameObject Purgatorius;
	public GameObject terrier;

	private Transform boardHolder;

	private List <Vector3> gridPositions = new List <Vector3> ();


	void start() {



	}
	void InitialiseList ()
		{
			//Clear our list gridPositions.
			gridPositions.Clear ();
			
			//Loop through x axis (columns).
			for(int x = 1; x < columns-1; x++)
			{
				//Within each column, loop through y axis (rows).
				for(int y = 1; y < rows-1; y++)
				{
					//At each index add a new Vector3 to our list with the x and y coordinates of that position.
					gridPositions.Add (new Vector3(x, y, 0f));
				}
			}
		}

	void BoardSetup()	{
		boardHolder = new GameObject("Board").transform;
		//Loop along x axis, starting from -1 (to fill corner) with floor or outerwall edge tiles.
			for(int x = 0; x < columns ; x++)
			{
				//Loop along y axis, starting from -1 to place floor or outerwall tiles.
				for(int y = 0; y < rows ; y++)
				{
				
					GameObject toInstantiate = arbre[Random.Range (0,arbre.Length)];
					if(x == 4 || x == columns || y == 2 || y == rows)


				}
					

			
			}

	}


}
