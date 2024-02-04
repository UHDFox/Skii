using Application.Skipass;
using Application.Tariff;
using Application.Visitor;
using Application.VisitorAction;
using AutoMapper;
using Domain.Entities.Tariff;
using Domain.Entities.Visitor;
using Web.Contracts.Skipass;
using Web.Contracts.Tariff;
using Web.Contracts.Visitor;
using Web.Contracts.VisitorActions;

namespace Web.Infrastructure.Automapper;

public sealed class WebProfile : Profile
{
    public WebProfile()
    {
        CreateMap<GetSkipassModel, SkipassResponse>().ReverseMap();
        
        CreateMap<GetTariffModel, TariffResponse>().ReverseMap();
        CreateMap<AddTariffModel, TariffRecord>().ReverseMap();
        CreateMap<AddTariffModel, TariffResponse>().ReverseMap();
        CreateMap<GetTariffModel, UpdateTariffModel>().ReverseMap();
        
        
        CreateMap<GetVisitorModel, VisitorResponse>().ReverseMap();
        CreateMap<AddVisitorModel, VisitorRecord>().ReverseMap();
        CreateMap<AddVisitorModel, VisitorResponse>().ReverseMap();
        CreateMap<GetVisitorModel, UpdateVisitorModel>().ReverseMap();
        CreateMap<UpdateVisitorModel, VisitorRecord>().ReverseMap();

        CreateMap<GetVisitorActionsModel, VisitorActionsResponse>().ReverseMap();
    }
}