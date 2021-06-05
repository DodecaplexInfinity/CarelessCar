using UnityEngine;

public class GameLogic : MonoBehaviour
{
	
	[SerializeField] private ObstacleCounter _obstacleCounter;
	private int _removedObstacleCount;

	[SerializeField] private ObstacleCatchers _obstacleCatchers;

	private void Start()
	{
		_obstacleCatchers.Initialize(CountObstacle);
	}

	public void CountObstacle()
	{
		_removedObstacleCount++;
		_obstacleCounter.UpdateText(_removedObstacleCount.ToString());
	}
}
