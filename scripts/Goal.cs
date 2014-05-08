using System;
using UnityEngine;

public class Goal
{
	public Goal (string gN, string d, GoalType gT, bool c = false)
	{
		goalName = gN;
		description = d;
		type = gT;
		complete = c;
	}
	
	public enum GoalType
	{
		Habit,
		Daily,
		OneTime
	};
	
	// snappy name
	public string goalName;
	// brief description
	public string description;
	// type of goal
	public GoalType type;
	// is the goal done for the day?
	public bool complete;
}