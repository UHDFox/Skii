using Application.Skipass;
using Application.Tariff;
using Application.Visitor;
using Application.VisitorAction;
using AutoMapper;
using Domain.Entities.Skipass;
using Domain.Entities.Tariff;
using Domain.Entities.Visitor;
using Domain.Entities.VisitorsAction;

namespace Application.Infrastructure.Automapper;

public sealed class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<AddSkipassModel, SkipassRecord>().ReverseMap();
        CreateMap<UpdateSkipassModel, SkipassRecord>().ReverseMap();
        CreateMap<GetSkipassModel, SkipassRecord>().ReverseMap();

        CreateMap<TariffRecord, GetTariffModel>().ReverseMap();
        CreateMap<AddTariffModel, TariffRecord>().ReverseMap();
        CreateMap<UpdateTariffModel, TariffRecord>().ReverseMap(); ;

        CreateMap<VisitorRecord, GetVisitorModel>().ReverseMap();
        CreateMap<AddVisitorModel, VisitorRecord>().ReverseMap();
        CreateMap<UpdateVisitorModel, VisitorRecord>().ReverseMap();
        
        CreateMap<AddVisitorActionsModel, VisitorActionsRecord>();
        CreateMap<GetVisitorActionsModel, VisitorActionsRecord>().ReverseMap();
        CreateMap<UpdateVisitorActionsModel, VisitorActionsRecord>().ReverseMap();
    }
}