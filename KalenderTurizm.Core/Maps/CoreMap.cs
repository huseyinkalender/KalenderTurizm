using KalenderTurizm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Core.Maps
{
    public class CoreMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity, new()
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
           
        }
        
    }
}
