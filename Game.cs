using System;
using System.Collections.Generic;

public class Game
{
	public String name;
	public List<Rank> ranks;


	public Game(String name)
	{
		this.name = name;
		ranks = new List<Rank>();
	}

	public void addRank(Rank rank)
    {
		ranks.Add(rank);
    }
}
