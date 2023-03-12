using System;

public class Rank
{
	public String RankName;
	public Rank nextRank;
	public Rank prevRank;
	public Game game;


	public Rank(string RankName, Game game)
	{
		this.RankName = RankName;
		this.game = game;
		game.addRank(this);
	}

	public void setNextRank(Rank nextRank)
    {
		this.nextRank = nextRank;
    }

	public void setPrevRank(Rank prevRank)
	{
		this.prevRank = prevRank;
	}
}
