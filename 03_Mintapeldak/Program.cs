using Microsoft.Win32.SafeHandles;

Console.Write("Upvotes ↑ : ");
int upvote = int.Parse(Console.ReadLine());
Console.Write("Downvotes ↓ : ");
int downvote = int.Parse(Console.ReadLine());
int result = 0;

if (upvote == downvote) //0 upvotes
{
    result = 0;
}

else if (upvote > downvote) //positive upvotes
{
    result = upvote - downvote;
}

else if (upvote < downvote) //negative upvotes (downvotes), there will be a minus before the number
{
    result = downvote - upvote;
}

string displayedVotes = upvote >= downvote ? @$"
↑ {result}" : @$"↑ {-result}";

Console.WriteLine(displayedVotes);