using allforone.Services.L0_Hello;
using allforone.Services.L1_Sum;
using allforone.Services.L2_Question;
using allforone.Services.L3_Compare;
using allforone.Services.L4_Madlib;
using allforone.Services.L5_OddEven;
using allforone.Services.L6_ReverseStr;
using allforone.Services.L7_ReverseNum;
using allforone.Services.L8_MagicBall;
using allforone.Services.L9_Restaurant;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(option => {
    option.AddPolicy("CorsPolicy", 
                    builder => {
                        builder.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                    }
    );
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHelloService, HelloService>();
builder.Services.AddScoped<ISumService, SumService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<ICompareService, CompareService>();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphaService, ReverseItAlphaService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();
builder.Services.AddScoped<IMagicBallService, MagicBallService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
