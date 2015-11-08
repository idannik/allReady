﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.Logging;

namespace AllReady.Services
{
    public class FakeQueueWriterService : IQueueStorageService
    {
        private readonly ILogger _logger;

        public FakeQueueWriterService(ILogger<FakeQueueWriterService> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string queueName, string message)
        {
            _logger.LogInformation("Message to {queueName} queue: {message}", queueName, message);
        }
    }
}