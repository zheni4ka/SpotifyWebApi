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
    public class PlaylistEntityConfigs : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Playlists");

            builder.HasOne(x => x.User).WithMany(x => x.Playlists).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Tracks).WithMany(x => x.Playlists);
            builder.HasOne(x => x.Category).WithMany(x => x.Playlists);
        }
    }
}
