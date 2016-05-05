using System.Data.Entity;

namespace TestAsp.NetMvcFluentModelBinding.Models
{
    public partial class MoneyDB : DbContext
    {
        public MoneyDB()
            : base("name=MoneyDB")
        {
        }

        public virtual DbSet<CollectionFailureLog> CollectionFailureLogs { get; set; }
        public virtual DbSet<CollectionLog> CollectionLogs { get; set; }
        public virtual DbSet<CollectionRequest> CollectionRequests { get; set; }
        public virtual DbSet<Mandate> Mandates { get; set; }
        public virtual DbSet<MoneyInToken> MoneyInTokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollectionFailureLog>()
                .Property(e => e.CollectionType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionFailureLog>()
                .Property(e => e.CollectionSubtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionFailureLog>()
                .Property(e => e.FailureCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionFailureLog>()
                .Property(e => e.FailureDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CollectionFailureLog>()
                .Property(e => e.PolicyNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CollectionFailureLog>()
                .Property(e => e.ReportedTo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionLog>()
                .Property(e => e.EventType)
                .IsFixedLength();

            modelBuilder.Entity<CollectionLog>()
                .Property(e => e.EventOutcome)
                .IsFixedLength();

            modelBuilder.Entity<CollectionLog>()
                .Property(e => e.FileFormat)
                .IsFixedLength();

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.PolicyNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.CollectionType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.CollectionSubtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.Mode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.RejectionCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CollectionRequest>()
                .Property(e => e.Currency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mandate>()
                .Property(e => e.PayorRelationship)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mandate>()
                .Property(e => e.IBAN)
                .IsUnicode(false);

            modelBuilder.Entity<Mandate>()
                .Property(e => e.PolicyNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Mandate>()
                .Property(e => e.CollectionType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mandate>()
                .Property(e => e.CollectionSubtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MoneyInToken>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<MoneyInToken>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<MoneyInToken>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MoneyInToken>()
                .Property(e => e.Currency)
                .IsFixedLength();

            modelBuilder.Entity<MoneyInToken>()
                .Property(e => e.PolicyNumber)
                .IsUnicode(false);
        }
    }
}
