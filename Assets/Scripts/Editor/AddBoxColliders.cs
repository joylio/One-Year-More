using System;
using UnityEngine;
using UnityEditor;


public static class AddBoxCollider
{
	[MenuItem("Ritual/Add Colliders to selected")]
	public static void AddCollidersToSelected()
	{
		foreach (GameObject o in Selection.gameObjects) {
			BoxCollider2D box = o.GetComponent<BoxCollider2D> ();
			if (box == null) {
				o.AddComponent<BoxCollider2D> ();
			}
		}
	}
}