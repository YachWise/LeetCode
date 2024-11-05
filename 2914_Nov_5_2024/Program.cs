public class Program
{
    public static void Main(String[] args)
    {
        MinChanges("1100111");
    }
    public static int MinChanges(string s)
    {

        //this will be our return value for the number of changes needed to be made for a "Beautiful" string
        var counter = 0;

        //create character array to hold the string
        char[] charArr;

        //fill character array with s, starting at index 0, length of the given string 
        charArr = s.ToCharArray(0, s.Length);


        /**
        Logic Thought Process and Rundown: 
        In the initial example, our s = 1001
        meaning, s[1] (0) and s[2] (0) need to be changed for [11][00] partitioned string
        How can we arrive to this? 

        # Idea 1
        Initially, a lazy option is always a brute force solution, which will almost always be the least efficient/optimized solution 
        This would be done by iterating through the character array [1,0,0,1]
        Looking forwards and backwards to see if there's a match, moving forward, repeating


        #Idea 2
        Normally, I follow my brute force option with deciding if BFS (Breadth First Search) or DFS (Depth First Search) are an option
        If they are, which one, why 
        And implement. 
        This is not a tree node problem, but I do like the general concept behind BFS here, look left, look right, continue
        For our final idea it will be a combination of both Idea 1 and Idea 2.

        #Idea 3
        I would like to use the BFS concept of left/right with the brute force iteration instead of the usual queue implementation
        Something more run of the mill greedy.

        for loop, iterate while less than character arrays length, add 2 to our iteration value 
        check if the arrays iteration value does not equal array iteration value - 1, if so, add to our count
        **/


        for (int i = 1; i < charArr.Length; i += 2)
        {
            if (charArr[i] != charArr[i - 1])
            {
                counter++;
            }
        }


        //this is just so i can see my answers locally.
        Console.WriteLine(counter);
        //return the number of changes made by referencing our counter.
        return counter;
    }

}