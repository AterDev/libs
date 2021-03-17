using System;
using System.Diagnostics.CodeAnalysis;
using Gov.Entity;
using Microsoft.EntityFrameworkCore;

namespace Gov.Context
{
    public class GovContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountExtend> AccountExtends { get; set; }
        public DbSet<ActionLog> ActionLogs { get; set; }
        public DbSet<ApproveFlow> ApproveFlows { get; set; }
        public DbSet<ApproveFlowSteps> ApproveFlowSteps { get; set; }
        public DbSet<ApproveFlowStatus> ApproveFlowStatuses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCatalog> ArticleCatalogs { get; set; }
        public DbSet<ArticleExtend> ArticleExtends { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<AuthorityGroup> AuthorityGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<EnterpriseInfo> EnterpriseInfos { get; set; }
        public DbSet<EnterpriseExtend> EnterpriseExtends { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCatalog> ProductCatalogs { get; set; }
        public DbSet<ProductExtend> ProductExtends{ get; set; }
        public DbSet<Role> Roles{ get; set; }

        public GovContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected GovContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account>(e =>
            {
                e.HasIndex(a => a.Email);
                e.HasIndex(a => a.Phone);
                e.HasIndex(a => a.Username);
                e.HasIndex(a => a.IsDeleted);
                e.HasIndex(a => a.PhoneConfirm);
                e.HasIndex(a => a.EmailConfirm);
                e.HasIndex(a => a.CreatedTime);
            });
            builder.Entity<AccountExtend>(e =>
            {
                e.HasIndex(a => a.RealName);
                e.HasIndex(a => a.Country);
                e.HasIndex(a => a.Province);
                e.HasIndex(a => a.City);

            });

            base.OnModelCreating(builder);
        }
    }
}
