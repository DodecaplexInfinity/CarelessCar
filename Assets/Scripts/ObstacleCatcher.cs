using System;
using UnityEngine;

namespace DefaultNamespace
{
	public class ObstacleCatcher:MonoBehaviour
	{
		
		private Action _onObstacleCatched;

		public void Initialize(Action onObstacleCatched)
		{
			_onObstacleCatched = onObstacleCatched;
		} 
		
		private void OnTriggerEnter(Collider other)
		{
			Debug.Log("OC Collission");
			if (other.gameObject.CompareTag("Obstacle"))
			{
				var obstacle = other.gameObject.GetComponent<Obstacle>();
				obstacle.SetControllable(false);
			
				_onObstacleCatched();
			}
		}
	}
}