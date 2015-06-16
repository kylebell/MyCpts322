using System;


public class Transition
{
    //Fields
    string TransitionName;
    Node StartNode;
    Node DestinationNode;
    string RequiredLetter;//Will be just a letter but using string if we want to go for more
    //Constructor
	public Transition()
	{
    }
    //Methods
    public void setTransitionName (string newName)
    {
        TransitionName = newName;
    }
    public void setTranstionPath (Node newStart, Node newDestination)
    {
        StartNode = newStart;
        DestinationNode = newDestination;
    }
    public string getTransitionName()
    {
        return TransitionName;
    }
    public Node getStartNode()
    {
        return StartNode;
    }
    public Node getDestinationNode()
    {
        return DestinationNode;
    }
    public string getRequiredLetter()
    {
        return RequiredLetter;
    }
}
