using iClientesRepository;
using clienteRepository;
using iPresupuestosRepository;
using presupuestoRepository;
using iProductosRepository;
using productoReposotory;
using iUsuariosRepository;
using usuarioReposiroty;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
options.IdleTimeout = TimeSpan.FromSeconds(10);
options.Cookie.HttpOnly = true;
options.Cookie.IsEssential = true;
});

builder.Services.AddScoped<IUsuariosRepository, UsuariosRespository>();
builder.Services.AddSingleton<IClientesRepository, ClientesRepository>();
builder.Services.AddSingleton<IProductosRepository, ProductosRepository>();
builder.Services.AddSingleton<IPresupuestosRepository, PresupuestosRepository>();



// Add services to the container.
builder.Services.AddControllersWithViews();

var cadenaDeConexion = builder.Configuration.GetConnectionString("SqliteConexion")!.ToString();
builder.Services.AddSingleton(cadenaDeConexion);


var app = builder.Build();

app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
