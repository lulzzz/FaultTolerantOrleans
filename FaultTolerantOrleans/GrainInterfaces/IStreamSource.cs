﻿using System;
using System.Threading.Tasks;
using Orleans;
using SystemInterfaces.Model;

namespace SystemInterfaces
{
	public interface IStreamSource : IGrainWithStringKey
	{
	    Task<Guid> Join(string nickname);
	    Task<Guid> Leave(string nickname);
	    Task<bool> Message(StreamMessage msg);
	    Task<StreamMessage[]> ReadHistory(int numberOfMessages);
	    Task<string[]> GetMembers();
        Task<Task> ProduceMessageAsync(StreamMessage msg);

        //Use for testing purpose
        Task<IBatchCoordinator> GetBatchManager();
        Task<IBatchTracker> GetBatchTracker();
    }
}
