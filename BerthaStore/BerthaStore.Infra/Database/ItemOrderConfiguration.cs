using BerthaStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Database
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            throw new NotImplementedException();
        }
    }
}
