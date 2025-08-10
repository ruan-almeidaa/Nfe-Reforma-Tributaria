using CalculoImposto.Controllers;
using CalculoImposto.Infra;
using CalculoImposto.Integrations.CalculadoraConsumo.Services;
using Helpers;
using Integrations.Base;
using Microsoft.AspNetCore.Mvc;
using NfeXml.Controllers;
using NfeXml.Infra;

var builder = WebApplication.CreateBuilder(args);

//Adiciona "Controllers" dos m�dulos
builder.Services.AddControllers()
    .AddApplicationPart(typeof(NfeXmlController).Assembly)
    .AddApplicationPart(typeof(CalculoImpostoController).Assembly);


//Executa configura��es de cada m�dulo
builder.Services.ConfiguraIntegracoes(builder.Configuration);
builder.Services.AddModuloNfeXml(builder.Configuration);
builder.Services.AddModuloCalculoImposto(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Retorna os erros no padr�o da ResponseModel
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var erros = context.ModelState.Values
            .SelectMany(v => v.Errors)
            .Select(e => e.ErrorMessage)
            .ToList();

        var response = new PadraoRespostasApi<object>
        {
            Dados = erros,
            Mensagem = "Erro de valida��o",
            HttpStatusCode = System.Net.HttpStatusCode.BadRequest
        };

        return new BadRequestObjectResult(response);
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
