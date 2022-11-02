using Autofac;
using Takoha.Core.Interfaces;

namespace Takoha.Core;
public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    //builder.RegisterType<ToDoItemSearchService>()
       // .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
