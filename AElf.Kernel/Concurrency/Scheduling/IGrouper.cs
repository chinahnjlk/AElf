﻿using System.Collections.Generic;

namespace AElf.Kernel.Concurrency.Scheduling
{
	public interface IGrouper
    {
		List<List<Transaction>> Process(List<Transaction> transactions);
    }
}