var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();  // Agregar soporte para controladores
builder.Services.AddEndpointsApiExplorer();  // Explorar los endpoints para la documentación
builder.Services.AddSwaggerGen();  // Configurar Swagger para la documentación de la API

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Usar Swagger en desarrollo para documentar la API
    app.UseSwaggerUI();  // Usar la interfaz de usuario de Swagger
}

app.UseHttpsRedirection();  // Redireccionar a HTTPS

app.UseAuthorization();  // Habilitar la autorización

app.MapControllers();  // Mapear rutas a los controladores

app.Run();  // Ejecutar la aplicación
