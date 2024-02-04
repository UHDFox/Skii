using Domain.Entities.Skipass;
using Domain.Enums;

namespace Application.VisitorAction;

public class UpdateVisitorActionsModel
{
    public UpdateVisitorActionsModel(Guid id, Guid skipassId, Place place, DateTime time, int balanceChange, bool isVip)
    {
        Id = id;
        SkipassId = skipassId;
        Place = place;
        Time = time;
        BalanceChange = balanceChange;
        IsVip = isVip;
    }

    public Guid Id { get; set; }

    public Guid SkipassId { get; set; }

    public Place Place { get; set; }

    public DateTime Time { get; set; }

    public int BalanceChange { get; set; }

    public bool IsVip { get; set; }
}