namespace svelte_blazor.Pages.Part1.Logic.AwaitBlocks;

public static class Utils
{
    public static async Task<int> getRandomNumber()
    {
        await Task.Delay(1000);
        if (new Random().Next(1, 5) == 1)
        {
            throw new Exception("Request failed");
        }
        return new Random().Next(1, 100);
    }
}