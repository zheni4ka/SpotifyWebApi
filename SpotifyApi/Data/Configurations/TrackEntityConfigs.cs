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
    public class TrackEntityConfigs : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Tracks");

            builder.HasMany(x => x.Playlists).WithMany(x => x.Tracks);
            builder.HasOne(x => x.Album).WithMany(x => x.Tracks);

        }
    }
}
