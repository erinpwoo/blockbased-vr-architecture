using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBlock
{

	//MVC NOTES:
	//- includes all code, variables, functions etc. in blockmanager.cs
	//- need to make an array/list/best data structure option of active blocks
	//- separate Spawn functions to split tasks up between M/V/C
	//- start/update functions update frames, should update view components as well



	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}




	public GameObiject motionblock_moveforward;
	public GameObject motionblock_turnRight;
	public GameObject motionblock_turnLeft;
	public GameObject spawnNode;

	/// <summary>Spawns a "Move Forward" motion block at the spawn node.</summary>
	/// <param name="d"></param>
	public void SpawnMoveForward(int d) { 
		GameObject clone;
		clone = Instantiate(motionblock_moveforward, spawnNode.transform.position, spawnNode.transform.rotation) as GameObject;
		clone.GetComponent<BlockInfo>().opcode = "move_forward";
		clone.GetComponent<BlockInfo>().setParam(d);
	}

	/// <summary>
	/// Spawns a "Turn Right" motion block at the spawn node.
	/// </summary>
	/// <param name="d"></param>
	public void SpawnTurnRight(int d) {
		GameObject clone;
		clone = Instantiate(motionblock_turnRight, spawnNode.transform.position, spawnNode.transform.rotation) as GameObject;
		clone.GetComponent<BlockInfo>().opcode = "turn_right";
		clone.GetComponent<BlockInfo>().setParam(d);
	}

	/// <summary>
	/// Spawns a "Turn Left" motion block at the spawn node.
	/// </summary>
	/// <param name="d"></param>
	public void SpawnTurnLeft(int d) {
		GameObject clone;
		clone = Instantiate(motionblock_turnLeft, spawnNode.transform.position, spawnNode.transform.rotation) as GameObject;
		clone.GetComponent<BlockInfo>().opcode = "turn_left";
		clone.GetComponent<BlockInfo>().setParam(d);
	}
}

