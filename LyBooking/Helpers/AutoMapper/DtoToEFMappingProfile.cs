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
    public class DtoToEFMappingProfile : Profile
    {
        public DtoToEFMappingProfile()
        {
            CreateMap<AccountDto, Account>()
                .ForMember(d => d.AccountType, o => o.Ignore());
            CreateMap<AccountTypeDto, AccountType>()
                .ForMember(d => d.Accounts, o => o.Ignore());
            CreateMap<PlanDto, Plan>();
            CreateMap<MailingDto, Mailing>();
            CreateMap<ToDoListDto, ToDoList>();
            CreateMap<UserForDetailDto, Account>();
            CreateMap<OCDto, Oc>();

            CreateMap<OCDto, Oc>();
            CreateMap<AccountRoleDto, AccountRole>();
            CreateMap<AccountPermissionDto, AccountPermission>();
            CreateMap<AccountGroupDto, AccountGroup>();
            CreateMap<EmployeeDto, Employee>();


            CreateMap<EmployeeDto, Employee>();
            CreateMap<MethodDto, Method>();
            CreateMap<SystemLanguageDto, SystemLanguage>();
            CreateMap<FunctionDto, FunctionSystem>();
            CreateMap<ModuleDto, Module>();

            CreateMap<RoleDto, Role>();
            CreateMap<RoomDto, Room>();

            CreateMap<XAccountDto, XAccount>();
            CreateMap<XAccountGroupDto, XAccountGroup>();
            CreateMap<SysMenuDto, SysMenu>();

            CreateMap<Customer, CustomerDto>();
           
            CreateMap<CodePermission, CodePermissionDto>();
            CreateMap<ReportConfig, ReportConfigDto>();

            CreateMap<StoredProcedure, StoredProcedureDto>();
            CreateMap<SysMenu, ChartSettingDto>();
            CreateMap<CodeType, CodeTypeDto>();
            CreateMap<Dashboard, DashboardDto>();
            
           
            CreateMap<SystemConfig, SystemConfigDto>();
            CreateMap<Hall, HallDto>();
            CreateMap<Site, SiteDto>();
            CreateMap<WorkOrder, WorkOrderDto>();

            CreateMap<GlueDto,Glue>();
            CreateMap<ChemicalDto, Chemical>();
            CreateMap<GlueChemicalDto, GlueChemical>();
            CreateMap<ShoeDto, Shoe>();
            CreateMap<ShoeGlueDto, ShoeGlue>();


        }
    }
}
