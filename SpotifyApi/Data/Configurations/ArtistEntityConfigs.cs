using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Data.Configurations
{
    public class ArtistEntityConfigs : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Artists");

            builder.HasOne(x => x.Producer).WithMany(x => x.Artists).HasForeignKey(x => x.ProducerId);

            builder.HasMany(x => x.Albums).WithOne(x => x.Artist).HasForeignKey(x => x.ArtistId);

            builder.HasOne(x => x.Country).WithMany(x => x.Artists).HasForeignKey(x => x.CountryId);

        }

    }
}
