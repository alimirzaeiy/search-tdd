using search_tdd;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("hello i am a blackboard understand are you good that is a pen");


        indexing Indexing = new indexing(list);
        Indexing.Search("understand");
        
    }
}