using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController instance;

	[Header("Hand Controllers")]
	public PlayerHand playerHand;
	public EnemyHand  enemyHand;

	[Header("Match Messages")]
	public Text messageInfo;

	[Header("Match Settings")]
	public float transitionTime=2;

	void Awake(){
		instance = this;
	}

	public void StartMatch(){
		enemyHand.DefineRandomHand ();
		if (playerHand.HandType != enemyHand.HandType) {
			bool wins = (playerHand.HandType == HandType.STONE && enemyHand.HandType == HandType.CUT) ||
			            (playerHand.HandType == HandType.PAPER && enemyHand.HandType == HandType.STONE) ||
			            (playerHand.HandType == HandType.CUT && enemyHand.HandType == HandType.PAPER);

			if (wins)
				messageInfo.text = "<color=green>Você venceu! Parabéns!</color>";
			else
				messageInfo.text = "<color=red>Perdeu playboy!</color>";

		} else {
			messageInfo.text = "<color=orange>\"Impatô\"</color>";
		}

		Invoke ("ResetMatch", transitionTime);
	}

	public void ResetMatch(){
		playerHand.Reset ();
		enemyHand.Reset ();
		messageInfo.text = "";
	}
}
