<Query Kind="Program" />

//problem: 1. largest element in arrary

void Main()
{
	var input = new int[]{-1,3,6,2,9,67};
	FindLargestElement(input).Dump();
}

public int FindLargestElement(int[] input)
{
	int length = input.Length-1, max=input[0];
	for(int i =1; i<= length; i++)
	{
		if(input[i] > max)
		{
			max = input[i];
		}
	}
	return max;
}

//Time complexity : worst case O(n)
// Space Complexity: O(1)