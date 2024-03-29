﻿using AutoMapper;
using LyBooking.Data;
using LyBooking.DTO;
using LyBooking.Models;
using LyBooking.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyBooking.Services
{
    public interface IMailingService: IServiceBase<MailingDto, MailingDto>
    {
    }
    public class MailingService : ServiceBase<MailingDto, MailingDto>, IMailingService
    {
        private readonly IRepositoryBase<MailingDto> _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configMapper;
        public MailingService(
            IRepositoryBase<MailingDto> repo, 
            IUnitOfWork unitOfWork,
            IMapper mapper, 
            MapperConfiguration configMapper
            )
            : base(repo, unitOfWork, mapper,  configMapper)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configMapper = configMapper;
        }
    }
}
