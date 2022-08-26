using UnityEngine;
using UnityEngine.UI; // We have to add the UnityEngine.UI namespace in order to work with Text variables

public class ball : MonoBehaviour
{
	public Text scorerightText;
	public Text scoreleftText;
	int scoreRight;
	int scoreLeft;



	public void OnCollisionEnter2D(Collision2D collision)
	{




		if (col.gameObject.name == "rightwall")
		{
			//this line will just add 1 point to the score
			scoreLeft++;
			//this line will convert the int score variable to a string variable
			scorelefttext.text = scoreLeft.ToString();
		}
		if (col.gameObject.name == "leftwall")
		{
			scoreRight++;
			scorerighttext.text = scoreRight.ToString();
		}

	}
}
	
