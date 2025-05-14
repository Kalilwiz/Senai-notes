using Senai_notes.Context;
using Senai_notes.Interfaces;
using Senai_notes.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SenaiNotesContext, SenaiNotesContext>();

builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
