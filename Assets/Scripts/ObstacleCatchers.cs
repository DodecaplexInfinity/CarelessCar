using System;
using DefaultNamespace;
using UnityEngine;

public class ObstacleCatchers : MonoBehaviour
{
	[SerializeField] private ObstacleCatcher[] _catchers; 
	
	public void Initialize(Action onObstacleCatched)
	{
		foreach (var catcher in _catchers)
		{
			catcher.Initialize(onObstacleCatched);
		}
	}
}
