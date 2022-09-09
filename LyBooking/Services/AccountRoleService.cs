using AutoMapper;
using LyBooking.Data;
using LyBooking.DTO;
using LyBooking.Models;
using LyBooking.Services.Base;

namespace LyBooking.Services
{
    public interface IAccountRoleService: IServiceBase<AccountRole, AccountRoleDto>
    {
    }
    public class AccountRoleService : ServiceBase<AccountRole, AccountRoleDto>, IAccountRoleService
    {
        private readonly IRepositoryBase<AccountRole> _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configMapper;

        public AccountRoleService(
            IRepositoryBase<AccountRole> repo,
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
