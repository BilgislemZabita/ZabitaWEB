using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework
{
    public class ZabitaDatabaseContext : DbContext
    {
        public DbSet<Amirlik> Amirliks { get; set; }
        public DbSet<Demirbas> Demirbases { get; set; }
        public DbSet<Mudurluk> Mudurluks { get; set; }
        public DbSet<Oda> Odas { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Sarf> Sarfs { get; set; }
        public DbSet<Yerleske> Yerleskes { get; set; }
        public DbSet<Tanimlamalar> Tanimlamalars { get; set; }
        public DbSet<YerleskeBakimOnarim> YerleskeBakimOnarims { get; set; }
        public DbSet<YerleskeIklimlendirme> YerleskeIklimlendirmes { get; set; }
        public DbSet<YerleskeTeknikBilgiler> YerleskeTeknikBilgilers { get; set; }
        public DbSet<MudurlukYerleskec> MudurlukYerleskecs { get; set; }
        public DbSet<AmirlikYerleskec> AmirlikYerleskecs { get; set; }
        public DbSet<OdaYerleskec> OdaYerleskecs { get; set; }
        public DbSet<Foto> Fotolars { get; set; }
        public DbSet<Yetki> Yetkis { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Modul> Moduls { get; set; }
        public DbSet<Takvim> Takvims { get; set; }
        public DbSet<UygulamaAyarlari> UygulamaAyarlaris { get; set; }
        public DbSet<Talep> Taleps { get; set; }
        public DbSet<IsTipleri> IsTipleris { get; set; }
        public DbSet<IsAltTipleri> IsAltTipleris { get; set; }
        public DbSet<TalepAltSonucu> TalepAltSonucus { get; set; }
        public DbSet<TalepSonucu> TalepSonucus { get; set; }
       // public ZabitaDatabaseContext(DbContextOptions<ZabitaDatabaseContext> dbContextOptions) : base(dbContextOptions) { }

        //public ZabitaDatabaseContext():base()
        //{
        //}

        /*      public DbSet<MudurlukYerleskec> MudurlukYerleskecs { get; set; }
              public DbSet<AmirlikYerleskec> AmirlikYerleskecs { get; set; }
              public DbSet<OdaYerleskec> OdaYerleskecs { get; set; }*/
      //  public ZabitaDatabaseContext(
      //DbContextOptions options,
      //IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
      //  {
      //  }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseNpgsql("Host=rogue.db.elephantsql.com;Database=kjnzrnst;Username=kjnzrnst;Password=c1eikpfygm6lmEiqLZIx8CRA4kFqQOiG");
           // optionsBuilder.UseNpgsql("Host=rogue.db.elephantsql.com;Database=ffwogiyc;Username=ffwogiyc;Password=ZsZU4aVdxV2WqyzOsx-PHOXxDzfsRS3L;sslmode=Require;Trust Server Certificate=true");
          //  optionsBuilder.UseNpgsql("Host=ec2-176-34-123-50.eu-west-1.compute.amazonaws.com; Database=d4oi9gogogbs90;Username=cojlrwoxdvntrm;Password=e6c936baf9f06dc54a9bd1a33c3637e05995b1b218f6aaa07257ab22a8e2a39b;sslmode = Require; Trust Server Certificate = true") ;
           optionsBuilder.UseNpgsql("Host=localhost;Database=demirbaspersonelsarf;Username=postgres;Password=zabita2143");
            //optionsBuilder.UseNpgsql("Host=postgresqln1.ibb.gov.tr;Database=demirbaspersonelsarfdb;Username=demirbaspersonelsarfusr;Password=R3Q_d6F#y");
            //optionsBuilder.UseNpgsql("Host=10.4.100.137;Database=demirbaspersonelsarf;Username=postgres;Password=zabita2144");
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //modelBuilder.Entity<Personel>(entity => { entity.ToTable(name: "User"); });
            //modelBuilder.Entity<Yetki>(entity => { entity.ToTable(name: "Role"); });
            /*            ////////////////////////////

                        modelBuilder.Entity<OdaYerleskec>()
                        .HasKey(e => new { e.OdaId, e.YerleskeId });

                        modelBuilder.Entity<OdaYerleskec>()
                                    .HasOne(e => e.Oda)
                                    .WithMany(e => e.OdaYerleskecs)
                                    .HasForeignKey(e => e.OdaId);

                        modelBuilder.Entity<OdaYerleskec>()
                                    .HasOne(e => e.Yerleske)
                                    .WithMany(e => e.OdaYerleskecs)
                                    .HasForeignKey(e => e.YerleskeId)
                                     .OnDelete(DeleteBehavior.Cascade);

                        // .OnDelete(DeleteBehavior.Restrict);

                        /////////////////

                        modelBuilder.Entity<AmirlikYerleskec>()
                        .HasKey(e => new { e.AmirlikID, e.YerleskeId });

                        modelBuilder.Entity<AmirlikYerleskec>()
                                    .HasOne(e => e.Amirlik)
                                    .WithMany(e => e.AmirlikYerleskecs)
                                    .HasForeignKey(e => e.AmirlikID);

                        modelBuilder.Entity<AmirlikYerleskec>()
                                    .HasOne(e => e.Yerleske)
                                    .WithMany(e => e.AmirlikYerleskecs)
                                    .HasForeignKey(e => e.YerleskeId)
                                    .OnDelete(DeleteBehavior.Cascade);

                        //.OnDelete(DeleteBehavior.Restrict);

                        ////////////////////////////////
                        modelBuilder.Entity<MudurlukYerleskec>()
                        .HasKey(e => new { e.MudurlukId, e.YerleskeId });

                        modelBuilder.Entity<MudurlukYerleskec>()
                                    .HasOne(e => e.Mudurluk)
                                    .WithMany(e => e.MudurlukYerleskecs)
                                    .HasForeignKey(e => e.MudurlukId);

                        modelBuilder.Entity<MudurlukYerleskec>()
                                    .HasOne(e => e.Yerleske)
                                    .WithMany(e => e.MudurlukYerleskecs)
                                    .HasForeignKey(e => e.YerleskeId)
                                   .OnDelete(DeleteBehavior.Cascade);*/

            // .OnDelete(DeleteBehavior.Restrict);

            #region amirlik

            modelBuilder.Entity<Amirlik>()
                       .HasMany(p => p.Yerleskes)
                       .WithMany(p => p.Amirliks)
                       .UsingEntity<AmirlikYerleskec>(
           j => j
               .HasOne(pt => pt.Yerleske)
               .WithMany(t => t.AmirlikYerleskecs)
               .HasForeignKey(pt => pt.YerleskeId).OnDelete(DeleteBehavior.Cascade),
           j => j
               .HasOne(pt => pt.Amirlik)
               .WithMany(p => p.AmirlikYerleskecs)
               .HasForeignKey(pt => pt.AmirlikID).OnDelete(DeleteBehavior.Cascade),
           j =>
           {
               j.HasKey(t => new { t.YerleskeId, t.AmirlikID });
           });

            #endregion amirlik

            #region mudurluk

            modelBuilder.Entity<Mudurluk>()
            .HasMany(p => p.Yerleskes)
            .WithMany(p => p.Mudurluks)
            .UsingEntity<MudurlukYerleskec>(
                j => j
                    .HasOne(pt => pt.Yerleske)
                    .WithMany(t => t.MudurlukYerleskecs)
                    .HasForeignKey(pt => pt.YerleskeId).OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne(pt => pt.Mudurluk)
                    .WithMany(p => p.MudurlukYerleskecs)
                    .HasForeignKey(pt => pt.MudurlukId).OnDelete(DeleteBehavior.Cascade),
                j =>
                {
                    j.HasKey(t => new { t.YerleskeId, t.MudurlukId });
                });

            #endregion mudurluk

            #region oda

            modelBuilder.Entity<Oda>()
                        .HasMany(p => p.Yerleskes)
                        .WithMany(p => p.Odas)
                        .UsingEntity<OdaYerleskec>(
            j => j
                .HasOne(pt => pt.Yerleske)
                .WithMany(t => t.OdaYerleskecs)
                .HasForeignKey(pt => pt.YerleskeId).OnDelete(DeleteBehavior.Cascade),
            j => j
                .HasOne(pt => pt.Oda)
                .WithMany(p => p.OdaYerleskecs)
                .HasForeignKey(pt => pt.OdaId).OnDelete(DeleteBehavior.Cascade),
            j =>
            {
                j.HasKey(t => new { t.YerleskeId, t.OdaId });
            });

            #endregion oda

            #region Modul

            modelBuilder.Entity<Modul>()
                        .HasMany(p => p.Personels)
                        .WithMany(p => p.Moduls)
                        .UsingEntity<ModulPersonelc>(
            j => j
                .HasOne(pt => pt.Personel)
                .WithMany(t => t.ModulPersonelcs)
                .HasForeignKey(pt => pt.PersonelId).OnDelete(DeleteBehavior.Cascade),
            j => j
                .HasOne(pt => pt.Modul)
                .WithMany(p => p.ModulPersonelcs)
                .HasForeignKey(pt => pt.ModulId).OnDelete(DeleteBehavior.Cascade),
            j =>
            {
                j.HasKey(t => new { t.ModulId, t.PersonelId });
            });

            #endregion Modul

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}