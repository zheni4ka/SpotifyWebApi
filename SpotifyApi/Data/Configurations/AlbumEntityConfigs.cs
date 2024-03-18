using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BusinessLogic.Entities;

namespace DataAccess.Data.Configurations
{
    internal class AlbumEntityConfigs : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);

            entityTypeBuilder.ToTable("Albums");

        }
    }
}
