namespace GameOfLife.Tests;

public class GameOfLifeTests
{
    [Fact]
    public void AddBoardSize()
    {
		var board = new Board(10,10);
		Assert.Equal("10:10", board.GetSize());
    }
}