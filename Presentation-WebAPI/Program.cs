using StdCatalog.Application.Items.Queries.GetItemQuery;
using StdCatalog.Application.Items.Queries.GetAllItemsQuery;
using StdCatalog.Application.Items.Commands.CreateNewItemCommand;
using StdCatalog.Domain.Entities;
using StdCatalog.Persistence.Repositories;
using StdCatalog.Persistence.Repositories.Items;
using StdFilePersistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Item>, ItemRepositorytoFile>();
builder.Services.AddScoped<ICreateNewItemCommand,CreateNewItemCommand>();
builder.Services.AddScoped<IGetItemQuery, GetItemQuery>();
builder.Services.AddScoped<IGetAllItemsQuery, GetAllItemsQuery>();
builder.Services.AddScoped<IEntityToFile, EntityToFile>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
