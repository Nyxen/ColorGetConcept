using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityScript.Scripting.Pipeline;


public class ColorGetter : MonoBehaviour {

	// Use this for initialization
	private new SpriteRenderer renderer;
	
	public Text displayLabel;

	void Start ()
	{
		renderer = GetComponent<SpriteRenderer>();
		Color32[] data = renderer.sprite.texture.GetRawTextureData<Color32>().ToArray();
		StringBuilder text = new StringBuilder();

		
		for (int i = 0; i < data.Length; i++)
		{
			
			text.Append($"R:{data[i].r}, G:{data[i].g}, B:{data[i].b}");
			text.Append("\n");
		}

		displayLabel.text += text.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
