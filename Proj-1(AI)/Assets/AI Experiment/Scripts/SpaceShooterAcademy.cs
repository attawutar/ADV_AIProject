using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShooterAcademy : Academy
{
	public int hazards = 1;
	public int hazardsCount = 1;
	public static int score = 0;
	public Text scoreText;
	public Text stepText;
	public Text hazardsText;
	public Text hazardsCountText;

	private void Update()
	{
		if (scoreText != null)
		{
			scoreText.text = "Score: " + score;
		}
		if (stepText != null)
		{
			stepText.text = "Steps: " + currentStep;
		}
		if (hazardsText != null)
		{
			hazardsText.text = "Hazards: " + hazards;
		}
		if (hazardsCountText != null)
		{
			hazardsCountText.text = "Counts: " + hazardsCount;
		}
	}

	public override void AcademyReset()
	{
		hazards = (int)resetParameters["hazards"];
		hazardsCount = (int)resetParameters["hazards_count"];
		score = 0;
	}

	public override void AcademyStep()
	{

	}
}
