using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using ERP.PMS.Common.Entities;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade.Mapper
{
    public class MapperProfile : Profile
    {
        public static IEnumerable<Profile> GetAllProfiles()
        {
            var types = Assembly.GetAssembly(typeof(MapperProfile)).GetTypes()
                .Where(x => x.IsClass && x.IsPublic && x.IsSubclassOf(typeof(MapperProfile)))
                .ToList();

            foreach (var type in types)
            {
                yield return (Profile) Activator.CreateInstance(type);
            }
        }
    }

    public class WorkExperienceProfile : MapperProfile
    {
        public WorkExperienceProfile()
        {
            CreateMap<WorkExperience, WorkExperienceGetDto>();
            CreateMap<WorkExperienceAddDto, WorkExperience>();
            CreateMap<WorkExperienceChangeDto, WorkExperience>();
        }
    }

    public class ContractProfile : MapperProfile
    {
        public ContractProfile()
        {
            CreateMap<Contract, ContractGetDto>();
            CreateMap<ContractAddDto , Contract>();
            CreateMap<ContractChangeDto, Contract>();
        }
    }

    public class DependantProfile : MapperProfile
    {
        public DependantProfile()
        {
            CreateMap<Dependant, DependantGetDto>();
            CreateMap<DependantAddDto, Dependant>();
            CreateMap<DependantChangeDto, Dependant>();
        }
    }

    public class JobProfile : MapperProfile
    {
        public JobProfile()
        {
            CreateMap<Job, JobGetDto>();
            CreateMap<JobAddDto, Job>();
            CreateMap<JobChangeDto, Job>();
        }
    }

    public class JobApplicantProfile : MapperProfile
    {
        public JobApplicantProfile()
        {
            CreateMap<JobApplicant, JobApplicantGetDto>();
            CreateMap<JobApplicantAddDto, JobApplicant>();
            CreateMap<JobApplicantChangeDto, JobApplicant>();
        }
    }

    public class PersonnelProfile : MapperProfile
    {
        public PersonnelProfile()
        {
            CreateMap<Personnel, PersonnelGetDto>();
            CreateMap<PersonnelAddDto, Personnel>();
            CreateMap<PersonnelChangeDto, Personnel>();
        }
    }

    public class PersonnelStatusProfile : MapperProfile
    {
        public PersonnelStatusProfile()
        {
            CreateMap<PersonnelStatus, PersonnelStatusGetDto>();
            CreateMap<PersonnelStatusAddDto, PersonnelStatus>();
            CreateMap<PersonnelStatusChangeDto, PersonnelStatus>();
        }
    }

    public class SalaryContractProfile : MapperProfile
    {
        public SalaryContractProfile()
        {
            CreateMap<SalaryContract, SalaryContractGetDto>();
            CreateMap<SalaryContractAddDto, SalaryContract>();
            CreateMap<SalaryContractChangeDto, SalaryContract>();
        }
    }

    public class SalaryContractItemProfile : MapperProfile
    {
        public SalaryContractItemProfile()
        {
            CreateMap<SalaryContractItem, SalaryContractItemGetDto>();
            CreateMap<SalaryContractItemAddDto, SalaryContractItem>();
            CreateMap<SalaryContractItemChangeDto, SalaryContractItem>();
        }
    }

    public class SalaryDescriptionProfile : MapperProfile
    {
        public SalaryDescriptionProfile()
        {
            CreateMap<SalaryDescription, SalaryDescriptionGetDto>();
            CreateMap<SalaryDescriptionAddDto, SalaryDescription>();
            CreateMap<SalaryDescriptionChangeDto, SalaryDescription>();
        }
    }

    public class TimePerformanceItemProfile : MapperProfile
    {
        public TimePerformanceItemProfile()
        {
            CreateMap<TimePerformanceItem, TimePerformanceItemGetDto>();
            CreateMap<SalaryDescriptionAddDto, TimePerformanceItem>();
            CreateMap<SalaryDescriptionChangeDto, TimePerformanceItem>();
        }
    }

    public class TimePerformanceProfile : MapperProfile
    {
        public TimePerformanceProfile()
        {
            CreateMap<TimePerformance, TimePerformanceGetDto>();
            CreateMap<TimePerformanceAddDto, TimePerformance>();
            CreateMap<TimePerformanceChangeDto, TimePerformance>();
        }
    }
}