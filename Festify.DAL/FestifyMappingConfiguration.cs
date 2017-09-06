﻿using Highway.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Festify.DAL
{
    public class FestifyMappingConfiguration : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}