﻿using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
        logger)
        {
            _userService = new Lazy<IUserService>(() => new
            UserService(repositoryManager, logger));
        }
        public IUserService UserService => _userService.Value;
    }
}
