using Acessi_api.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;

namespace Acessi_api.EntityMap.User
{
    public class UserMap:IEntityTypeConfiguration<UserModel>
    {

        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            
            builder.ToTable("users");
            builder.Property(user => user.Id)
                .ValueGeneratedOnAdd();
            builder.Property(user => user.Name);
            builder.Property(user => user.Email);
            builder.Property(user => user.Password);

        }
    }
}
        