#nullable disable
using Server.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Server.Data.EntityConfigurations;

namespace Server.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Belief> Beliefs { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MeetingMember> MeetingMembers { get; set; }
    public DbSet<OrganizationRole> OrganizationRoles { get; set; }
    public DbSet<MemberRole> MemberRoles { get; set; }
    public DbSet<Value> Values { get; set; }
    public DbSet<Fundraiser> Fundraisers { get; set; }
    public DbSet<Donation> Donations { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUserRole>(userRole =>
        {
            userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

            userRole.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            userRole.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
        });
        builder.ApplyConfiguration(new MemberRoleConfiguration());
        builder.ApplyConfiguration(new MeetingMemberConfiguration());
    }

    public override int SaveChanges()
    {
        var changedEntities = ChangeTracker.Entries();

        foreach (var changedEntity in changedEntities)
        {
            if (changedEntity.Entity is Entity)
            {
                var entity = changedEntity.Entity as Entity;
                if (changedEntity.State == EntityState.Added)
                {
                    entity.Created = DateTime.Now;
                    entity.Updated = DateTime.Now;

                }
                else if (changedEntity.State == EntityState.Modified)
                {
                    entity.Updated = DateTime.Now;
                }
            }

        }
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        var changedEntities = ChangeTracker.Entries();

        foreach (var changedEntity in changedEntities)
        {
            if (changedEntity.Entity is Entity)
            {
                var entity = changedEntity.Entity as Entity;
                if (changedEntity.State == EntityState.Added)
                {
                    entity.Created = DateTime.Now;
                    entity.Updated = DateTime.Now;

                }
                else if (changedEntity.State == EntityState.Modified)
                {
                    entity.Updated = DateTime.Now;
                }
            }
        }
        return await base.SaveChangesAsync(true, cancellationToken);
    }
}
