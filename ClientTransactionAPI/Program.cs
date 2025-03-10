using ClientTransactionAPI.Contexts;
using ClientTransactionAPI.DTOs.Mappers;
using ClientTransactionAPI.Repositories.Client;
using ClientTransactionAPI.Repositories.Generic;
using ClientTransactionAPI.Repositories.Transaction;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database

builder.Services.AddSqlite<ApplicationDbContext>("Data Source=./database.db;");
builder.Services.AddScoped<ApplicationDbContext>();

#endregion

#region Repository

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

#endregion

#region Auto Mapper

builder.Services.AddAutoMapper(typeof(ClientDTOMapping));
builder.Services.AddAutoMapper(typeof(TransactionDTOMapping));

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();