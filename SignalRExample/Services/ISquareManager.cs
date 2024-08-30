namespace SignalRExample.Services;

public interface ISquareManager
{
    string[,] GetSquares();
    void SwapColor(int x, int y);
}
