using System.Linq;
using AutoMapper;
using ERP.PMS.Common.Entities;

namespace ERP.PMS.Facade.Mapper
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            var types = MapperProfile.GetAllProfiles().ToList();
            AutoMapper.Mapper.Initialize(conf => { types.ForEach(conf.AddProfile); });
        }


        public static TEntity ToEntity<TEntity, TDto>(this TDto dto) 
        {
            return AutoMapper.Mapper.Map<TDto, TEntity>(dto);
        }

        public static TDto ToDto<TEntity, TDto>(this TEntity entity) 
        {
            return AutoMapper.Mapper.Map<TEntity, TDto>(entity);
        }
    }
}