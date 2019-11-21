using System;

class ListExercises
{
    private string[] names = new string[10];
    private int nextFreeLocation = 0;

    // addName takes in a name, adds it to the list maintaining the order
    // passes back an integer (-1 if error), giving inserted location
    public int AddNameToList(string theName)
    {
        if (nextFreeLocation > names.Length) return -1;

        int position = 0;
        while ((position < nextFreeLocation) && (theName.CompareTo(names[position]) > 0))
        {
            position = position + 1;
        }

        for (int i = nextFreeLocation; i > position; i--)
        {
            names[i] = names[i - 1];
        }

        names[position] = theName;
        nextFreeLocation = nextFreeLocation + 1;
        return -1;
    }

    // FindPositionOfName locates a name in the list
    // passes back an integer (-1 if error), giving inserted location
    public int FindPositionOfName(string theName)
    {
        // not yet implemented
        return -1;
    }

    // GetListAsString just returns a formatted string of List
    public string GetListAsString()
    {
        string temp = "";
        for (int i = 0; i < nextFreeLocation; i++)
        {
            temp = temp + names[i] + "\n";
        }
        return temp;
    }
}