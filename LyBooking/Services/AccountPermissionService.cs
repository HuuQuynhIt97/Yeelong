using AutoMapper;
using LyBooking.Data;
using LyBooking.DTO;
using LyBooking.Models;
using LyBooking.Services.Base;

namespace LyBooking.Services
{
    public interface IAccountPermissionService: IServiceBase<AccountPermission, AccountPermissionDto>
    {
    }
    public class AccountPermissionService : ServiceBase<AccountPermission, AccountPermissionDto>, IAccountPermissionService
    {
        private readonly IRepositoryBase<AccountPermission> _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configMapper;

        public AccountPermissionService(
            IRepositoryBase<AccountPermission> repo,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            MapperConfiguration configMapper
            )
            : base(repo, unitOfWork, mapper, configMapper)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configMapper = configMapper;
        }
    }
}
