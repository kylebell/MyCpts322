using System;

public class Node
{
    //Fields
    string NodeName;
    int NodeType; //1 is initial 2 is final etc
    //Constructor
	public Node()
	{
    }
    //Methods
    public void setNodeName(string newName)
    {
        NodeName = newName;
    }
    public void setNodeType(int newType)
    {
        NodeType = newType;
    }
    public string getNodeName()
    {
        return NodeName;
    }
    public int getNodeType()
    {
        return NodeType;
    }
}
