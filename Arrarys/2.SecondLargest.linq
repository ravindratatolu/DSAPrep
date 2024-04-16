<Query Kind="Program" />

//problem: second  largest

void Main()
{
	var input = new int[]{55,1,5,2,4,7,6,9};
	FindSecondLargest(input).Dump();
}

public int FindSecondLargest(int[] input)
{
	int firstLargest = input[0], secondLargest = int.MinValue;
	
	for(int i =1; i<=input.Length-1; i++)
	{
		if(input[i] > firstLargest)
		{
			secondLargest = firstLargest;
			firstLargest = input[i];
		}
		else if(input[i] > secondLargest && input[i] !=firstLargest)
		{
			secondLargest = input[i];
		}
	}
	return secondLargest;
}
