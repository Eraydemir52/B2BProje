using B2BProje.Business.Abstract;
using B2BProje.Business.Concrete;
using B2BProje.DataAccess.Abstract;
using B2BProje.DataAccess.Concrete.EntityFramework;
using B2BProje.DataAccess.Concrete.EntityFramework.B2BProje.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the contain er.
        public void ConfigureServices(IServiceCollection services)
        {
            // DbContextOptions'ý doðru bir þekilde ayarla
            services.AddDbContext<B2BContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            // IBankaService ve BankaManager'ý ekleyin (baðýmlýlýklarýnýza göre ayarlayýn)
            services.AddScoped<IBankaDal, EfBankaDal>();
            services.AddScoped<IBankaService, BankaManager>();
            services.AddScoped<IMesajDal, EfMesajDal>();
            services.AddScoped<IMesajService, MesajManager>();
            services.AddScoped<IBayiDal, EfBayiDal>();
            services.AddScoped<IBayiService, BayiManager>();
            services.AddScoped<IAdresService, AdresManager>();
            services.AddScoped<IAdresDal, EfAdresDal>();
            services.AddScoped<IAyarService, AyarManager>();
            services.AddScoped<IAyarDal, EfAyarDal>();
            services.AddScoped<ISiparisService, SiparisManager>();
            services.AddScoped<ISiparisDal, EfSiparisDal>();
            services.AddScoped<ISiparisVerilenUrunService, SiparisVerilenUrunManager>();
            services.AddScoped<ISiparisVerilenDal, EfSiparisVerilenUrunDal>();
            services.AddScoped<IUrunDal, EfUrunDal>();
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IUreticiDal, EfUreticiDal>();
            services.AddScoped<IUreticiService, UreticiManager>();
            services.AddScoped<IKategoriDal, EfKategoriDal>();
            services.AddScoped<IKategoriService, KategoriManager>();
            services.AddScoped<IResimDal, EfResimDal>();
            services.AddScoped<IResimService, ResimManager>();
            services.AddScoped<ISiparisDurumDal, EfSiparisDurumDal>();
            services.AddScoped<ISiparisDurumService, SiparisDurumManager>();
            services.AddScoped<ISepetDal, EfSepetDal>();
            services.AddScoped<ISepetService, SepetManager>();
            services.AddScoped<IHavaleDal, EfHavaleDal>();
            services.AddScoped<IHavaleService, HavaleManager>();


            // Diðer servis eklemeleri...
            services.AddRazorPages();

            // API Controller'larýný etkinleþtir
            services.AddControllers();
        }





        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("AllowAll");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Bu satýrý ekleyin
                endpoints.MapRazorPages();
            });
        }

    }
}
