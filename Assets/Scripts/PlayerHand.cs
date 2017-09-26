using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : HandBase {

	// Use this for initialization
	void Start () {
		DefineHandType (HandType.NONE);
	}

	public void OnSelectStoneHand(){
		DefineHandType (HandType.STONE);
		GameController.instance.StartMatch ();
	}

	public void OnSelectCutHand(){
		DefineHandType (HandType.CUT);
		GameController.instance.StartMatch ();
	}

	public void OnSelectPaperHand(){
		DefineHandType (HandType.PAPER);
		GameController.instance.StartMatch ();
	}
}
