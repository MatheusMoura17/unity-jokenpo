using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHand : HandBase {

	public void DefineRandomHand(){
		DefineHandType ((HandType)Random.Range (1,4));
	}
}
