using System;

public class Rank
{
	public String RankName;
	public Rank nextRank;
	public Rank prevRank;
	public Game game;


	public Rank(string RankName, Rank nextRank, Rank prevRank, Game game)
	{
		this.RankName = RankName;
		this.nextRank = nextRank;
		this.prevRank = prevRank;
		this.game = game;
	}
}
