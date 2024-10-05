using EthanDependencyInjectionCourse.Classes;
using EthanDependencyInjectionCourse.Data;
using EthanDependencyInjectionCourse.Interfaces;
using Microsoft.Extensions.DependencyInjection;

//IServiceCollection collection = new ServiceCollection();
//collection.AddScoped<IDataAccess, DataAccessMySQL>();
//collection.AddScoped<IBusiness, Business>();
//collection.AddScoped<IBusiness, BusinessV2>();
//collection.AddScoped<UserInterface>();

//IServiceProvider provider = collection.BuildServiceProvider();

//UserInterface ui = provider.GetService<UserInterface>();

//ui.SignUp();


var collection2 = new ServiceCollection();
collection2.AddScoped<Scoped>();
collection2.AddScoped<Transient>();

var provider = collection2.BuildServiceProvider();

public class Scoped
{
    
}

public class Transient
{

}
