<Query Kind="Program" />

//Remove duplicates from sorted arrary
using System.Linq;
void Main()
{
	var input = new int[]{1,1,2,2,3,3,3,3};
	RemoveDuplicatesFromSortedArray(input).Dump();
}

//we are using two pointer apporach
public int RemoveDuplicatesFromSortedArray(int[] input)
{
	int i = 0;
	for(int j=1; j<=input.Length-1;j++)
	{
		if(input[i] != input[j])
		{
			int temp = input[i+1];
			input[i+1] = input[j];
			i++;
		}
	}
	input.Dump();
	
	return i;
}

public int[] BrutForceRemoveDuplicates(int[] input)
{
	Dictionary<int, int> dict = new Dictionary<int,int>();
	
	for(int i=0;i<=input.Length-1;i++)
	{
		if(!dict.TryGetValue(input[i],out int value))
		{
			dict.Add(input[i],1);
		}
		else{
			dict[input[i]]++;
		}
	}
	return dict.Keys.ToArray();
}
