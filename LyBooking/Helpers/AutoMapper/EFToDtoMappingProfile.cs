using AutoMapper;
using LyBooking.DTO;
using LyBooking.DTO.auth;
using LyBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyBooking.Helpers.AutoMapper
{
    public class EFToDtoMappingProfile : Profile
    {
        public EFToDtoMappingProfile()
        {
            var list = new List<int> { };
            CreateMap<Account, AccountDto>();
            CreateMap<AccountType, AccountTypeDto>();
            CreateMap<Plan, PlanDto>();
            CreateMap<Mailing, MailingDto>();
            CreateMap<ToDoList, ToDoListDto>();
            CreateMap<XAccount, UserForDetailDto>()
                .ForMember(d => d.Username, o => o.MapFrom(x => x.Uid))
                .ForMember(d => d.ID, o => o.MapFrom(x => x.AccountId));
            CreateMap<Oc, OCDto>();
            CreateMap<AccountRole, AccountRoleDto>();
            CreateMap<AccountPermission, AccountPermissionDto>();
            CreateMap<AccountGroup, AccountGroupDto>();
            CreateMap<Employee, EmployeeDto>();

            CreateMap<Employee, EmployeeDto>();
            CreateMap<Method, MethodDto>();
            CreateMap<SystemLanguage, SystemLanguageDto>();
            CreateMap<FunctionSystem, FunctionDto>();
            CreateMap<Module, ModuleDto>();

            CreateMap<Role, RoleDto>();
            CreateMap<Room, RoomDto>();
            CreateMap<XAccount, XAccountDto>();
            CreateMap<XAccountGroup, XAccountGroupDto>();
            CreateMap<SysMenu, SysMenuDto>();

            CreateMap<CustomerDto, Customer>();
 
            CreateMap<CodePermissionDto, CodePermission>();

            CreateMap<ReportConfigDto, ReportConfig>();

            CreateMap<StoredProcedureDto, StoredProcedure>();
            CreateMap<ChartSettingDto, SysMenu>();
            CreateMap<CodeTypeDto, CodeType>();
            CreateMap<DashboardDto, Dashboard>();
            CreateMap<SystemConfigDto, SystemConfig>();

            CreateMap<SiteDto, Site>();
            CreateMap<HallDto, Hall>();
            CreateMap<WorkOrderDto, WorkOrder>();
            CreateMap<BookingDetailDto, BookingDetail>();

            CreateMap<Glue, GlueDto>();
            CreateMap<Chemical, ChemicalDto>();
            CreateMap<GlueChemical, GlueChemicalDto>();
            CreateMap<Shoe, ShoeDto>();
            CreateMap<ShoeGlue, ShoeGlueDto>();
        }

    }
}
