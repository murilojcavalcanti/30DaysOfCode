 int MaxProfit(int[] prices)
{
	int diferenca = 0;
	int min = prices[0];
	for (int i = 1; i < prices.Length; i++)
	{
		if (prices[i] < min)
		{
			min = prices[i];
		}
		
		if ((prices[i]-min) > diferenca)
		{
            diferenca = prices[i]-min;
		}
	}


	return diferenca;
}


MaxProfit([1,2]);
