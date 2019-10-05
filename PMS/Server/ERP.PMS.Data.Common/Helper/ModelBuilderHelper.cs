//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration;
//using System.Linq;
//using System.Reflection;
//using ERP.PMS.Common.Entities;
//
//namespace ERP.PMS.Shared.Helper
//{
//    public static class ModelBuilderHelper
//    {
//        public static void RegisterEntityTypeConfiguration(this DbModelBuilder modelBuilder, params Assembly[] assemblies)
//        {
//            var ModelBuilder = typeof(BaseEntity).Assembly.GetTypes().Where(x => x.IsClass && x.IsSubclassOf(typeof(EntityTypeConfiguration<>))).ToList();
//            foreach (var type in ModelBuilder)
//            {
//                yield return (EntityTypeConfiguration) Activator.CreateInstance(type);
//            }
//
//            MethodInfo applyGenericMethod = typeof(DbModelBuilder).GetMethods().First(m => m.Name == nameof(ModelBuilder.ApplyConfiguration));
//
//            IEnumerable<Type> types = assemblies.SelectMany(a => a.GetExportedTypes())
//                .Where(c => c.IsClass && !c.IsAbstract && c.IsPublic);
//
//            foreach (Type type in types)
//            {
////                foreach (Type iface in type.GetInterfaces())
//                {
//                    if (iface.IsConstructedGenericType && iface.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
//                    {
//                        MethodInfo applyConcreteMethod = applyGenericMethod.MakeGenericMethod(iface.GenericTypeArguments[0]);
//                        applyConcreteMethod.Invoke(modelBuilder, new object[] { Activator.CreateInstance(type) });
//                    }
//                }
//            }
//        }
//        
//    }
//}