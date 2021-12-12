using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{
    public class PersonSeed : IEntityTypeConfiguration<Person>
    {
        private readonly int[] _ids;

        public PersonSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
            new Person {
                Id = 1,
                Name = "Mehmet",
                SurName = "Şener"
            },

            new Person { 
                Id = 2,
                Name = "Ahmet Yasin",
                SurName = "Bahçıvan"
            
            }
            );
        }
    }
}
