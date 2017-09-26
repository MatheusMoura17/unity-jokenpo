using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandBase : MonoBehaviour {

	[Header("Renderer")]
	[SerializeField]
	private Image handImage;

	[Header("Sprites")]
	[SerializeField]
	private Sprite stoneHandSprite;
	[SerializeField]
	private Sprite cutHandSprite;
	[SerializeField]
	private Sprite paperHandSprite;

	private HandType handType;

	public HandType HandType{
		get{ return handType; }
	}

	public void Reset(){
		DefineHandType (HandType.NONE);
	}

	public void DefineHandType(HandType type){
		handType = type;
		UpdateHandImage ();
	}

	private void UpdateHandImage(){
		switch (handType) {
		case HandType.PAPER:{
				handImage.sprite = paperHandSprite;
			}
			break;
		case HandType.CUT:{
				handImage.sprite = cutHandSprite;
			}
			break;
		case HandType.STONE:{
				handImage.sprite = stoneHandSprite;
			}
			break;
		default:{
				handImage.sprite = null;
			}
			break;
		}
	}
}
