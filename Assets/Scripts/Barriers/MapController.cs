﻿using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class MapController : MonoBehaviour
{
		public Transform someBarrier;
		public int  barrierCount = 10;
		public Vector2 mapSize = new Vector2 (20, 20);
		// Use this for initialization
		void Start ()
		{
				for (int i=0; i<barrierCount; i++) {
						Instantiate (someBarrier, new Vector3 (Random.Range (-mapSize.x, mapSize.x), 0.5f, Random.Range (-mapSize.y, mapSize.y)), Quaternion.identity);
				}
		}
}
